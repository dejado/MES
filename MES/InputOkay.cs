using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES
{
    public partial class InputOkay : Form
    {
        public InputOkay()
        {
            InitializeComponent();
            this.Size = new Size(1250, 650);
            ShowGrid();
            InputOk_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InputRe_pn.Visible=false;
        }

        private void ShowGrid()
        {
            InputOk_grid.Rows.Clear();
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=mes;Uid=MES;Pwd=mesProgram128!;");
                //SQL 서버와 연결, database=스키마 이름
                connection.Open();
                //SQL 서버 연결

                string Query = "SELECT * from test ORDER BY output_date ASC";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand command = new MySqlCommand(Query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    InputOk_grid.Rows.Add(reader["state"],reader["step"], reader["company"],
                        reader["product_code"], reader["product_name"], reader["product_num"],
                        reader["output_date"]);
                }
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

  





        private void InputClose_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string Num;
        string Company;
        string Code;
        string Step;
        string State;
        string Product;
        string Output_date;

        private void InputOk_grid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            InputRe_pn.Visible = true;
            DataGridViewRow selectedRow = InputOk_grid.SelectedRows[0];

            // 선택된 행의 각 열의 값을 가져오기
            Num = selectedRow.Cells["num1"].Value.ToString(); // num에 해당하는 데이터
            Company = selectedRow.Cells["company1"].Value.ToString();
            Code = selectedRow.Cells["code1"].Value.ToString();
            Step = selectedRow.Cells["step1"].Value.ToString();
            State = selectedRow.Cells["inspect1"].Value.ToString();
            Product = selectedRow.Cells["name1"].Value.ToString();
            Output_date = selectedRow.Cells["outputdate1"].Value.ToString();
        }

        private void InputRe_bt_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=mes;Uid=MES;Pwd=mesProgram128!;");
                //SQL 서버와 연결, database=스키마 이름
                connection.Open();

                string person = InputPerson_txt.Text;
                string location = InputLocation_txt.Text;
                string input_date = Input_date.Value.ToString("yyyy-MM-dd");

                CompareCode(Code);
                string insertQuery = string.Format("INSERT INTO input(state, step, company, product_code," +
                    " product_name, product_num, output_date, input_register, input_date, input_location)" +
                    " VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}');",
                    State, Step, Company, Code, Product, Num, Output_date, person, input_date, location);

                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                InputRe_pn.Visible = false;

                if (command.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("데이터 삽입에 실패했습니다.");
                    InputRe_pn.Visible = true;
                }
                else
                {
                    MessageBox.Show("데이터가 성공적으로 삽입되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CompareCode(string code)
        {

            string cnn = "Server=127.0.0.1;Database=mes;Uid=MES;Pwd=mesProgram128!;";
            using (MySqlConnection connection = new MySqlConnection(cnn))
            {
                //SQL 서버와 연결, database=스키마 이름
                connection.Open();
                string Query = "SELECT * from input";
                //ExcuteReader를 이용하여 연결모드로 데이터 가져오기
                MySqlCommand command = new MySqlCommand(Query, connection);
                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    if ( code== reader["product_code"].ToString())
                    {
                        MessageBox.Show("수정하시겠습니까?");
                        DeleteCode(code);

                    }
                }
            }
        }

        public void DeleteCode(string code)
        {
            string cnn = "Server=127.0.0.1;Database=mes;Uid=MES;Pwd=mesProgram128!;";
            using (MySqlConnection connection = new MySqlConnection(cnn))
            {
                // SQL 서버와 연결, database=스키마 이름
                connection.Open();

                // 입력할 문자 받아옴
                string insertQuery = "DELETE FROM input WHERE product_code=@code";

                // MySqlCommand는 MYSQL로 명령어를 전송하기 위한 클래스
                // MYSQL에 insertQuery 값을 보내고, connection 값을 보내 연결을 실시한다.
                // 위 정보를 command 변수에 저장
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@code", code);

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void Re_bt_Click(object sender, EventArgs e)
        {
            ShowGrid();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

    }
}
