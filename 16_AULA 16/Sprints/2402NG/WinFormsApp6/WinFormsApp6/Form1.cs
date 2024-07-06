namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_IMC_Click(object sender, EventArgs e)
        {
            try
            {
                string[] pares = textBoxDados.Text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                string resultados = "";
                for (int i = 0; i < pares.Length; i++)
                {
                    string[] valores = pares[i].Split(',');
                    if (valores.Length != 2)
                    {
                        MessageBox.Show("Por favor, insira pares de peso e altura válidos");
                        return;
                    }
                    double peso = Convert.ToDouble(valores[0]);
                    double altura = Convert.ToDouble(valores[1]);

                    double imc = peso / ((altura / 100 * altura / 100));

                    //categoria
                    string categoria = "";

                    if (imc <= 18.5)
                    {
                        categoria = "Abaixo do peso";
                    }
                    else if (imc > 18.6 & imc <= 24.9)
                    {
                        categoria = "Peso normal";
                    }
                    else if (imc > 25.0 & imc <= 29.9)
                    {
                        categoria = "Sobrepeso";
                    }
                    else if (imc > 30.0 & imc <= 34.9)
                    {
                        categoria = "Obesidade Grau I";
                    }
                    else if (imc > 35.0 & imc <= 39.9)
                    {
                        categoria = "Obesidade Grau II";
                    }
                    else
                    {
                        categoria = "Obesidade Grau III";
                    }
                    resultados += $"Par {i + 1}: IMC = {imc:F2}, Categoria = {categoria}\n";
                }
                resultado.Text = "Resultado do IMC:\n" + resultados;
                MessageBox.Show(resultados, "Resultado do IMC");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor insira valores válidos para a altura e peso");
            }
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            textBoxDados.Clear();
            resultado.Text = "Resultado";
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
