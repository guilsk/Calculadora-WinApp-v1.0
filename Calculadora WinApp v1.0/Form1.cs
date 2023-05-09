namespace Calculadora_WinApp_v1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tf_conta.Text = "";
        }
        private void bt_0_Click(object sender, EventArgs e)
        {
            tf_conta.AppendText("0");
        }

        private void bt_1_Click(object sender, EventArgs e)
        {
            tf_conta.AppendText("1");
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            tf_conta.AppendText("2");
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            tf_conta.AppendText("3");
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            tf_conta.AppendText("4");
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            tf_conta.AppendText("5");
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            tf_conta.AppendText("6");
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            tf_conta.AppendText("7");
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            tf_conta.AppendText("8");
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            tf_conta.AppendText("9");
        }

        private void bt_somar_Click(object sender, EventArgs e)
        {
            if (confereOperador())
            {
                tf_conta.AppendText("+");
                operador = "+";
            }
        }

        private void bt_subtrair_Click(object sender, EventArgs e)
        {
            if (confereOperador())
            {
                tf_conta.AppendText("-");
                operador = "-";
            }
        }

        private void bt_multiplicar_Click(object sender, EventArgs e)
        {
            if (confereOperador())
            {
                tf_conta.AppendText("*");
                operador = "*";
            }
        }

        private void bt_dividir_Click(object sender, EventArgs e)
        {
            if (confereOperador())
            {
                tf_conta.AppendText("/");
                operador = "/";
            }
        }

        string operador;

        private bool confereOperador()
        {
            if (tf_conta.Text != "" && !tf_conta.Text.Contains("+") && !tf_conta.Text.Contains("-") && !tf_conta.Text.Contains("*") && !tf_conta.Text.Contains("/"))
                return true;
            return false;
        }
        private void bt_igual_Click(object sender, EventArgs e)
        {
            try
            {
                string[] operacao = tf_conta.Text.Split(operador);
                int num1 = int.Parse(operacao[0]);
                int num2 = int.Parse(operacao[1]);
                int resultado = 0;
                string resultado_txt = "";

                if (operador == "+")
                {
                    resultado = num1 + num2;
                    resultado_txt = Convert.ToString(resultado);
                }
                else if (operador == "-")
                {
                    resultado = num1 - num2;
                    resultado_txt = Convert.ToString(resultado);
                }
                else if (operador == "*")
                {
                    resultado = num1 * num2;
                    resultado_txt = Convert.ToString(resultado);
                }
                else if (operador == "/")
                {
                    try
                    {
                        resultado = num1 / num2;
                        resultado_txt = Convert.ToString(resultado);
                    }
                    catch (Exception)
                    {
                        resultado_txt = "Não é possível dividir por zero(0)";
                    }
                }
                else
                {
                    resultado = 0;
                    resultado_txt = Convert.ToString(resultado);
                }

                tf_resultado.Text = resultado_txt;
            }
            catch
            {
                tf_resultado.Text = "Erro";
            }

        }
    }
}