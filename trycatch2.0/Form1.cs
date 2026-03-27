using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trycatch2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            //Declarando as variaveis
            int v1, v2;
            int resultado;

            try //Aqui ele tenta a execução
            {
                //e ligando elas as caixas de texto
                //Preferi liga-las aqui para poder
                //tratar elas no catch pois
                //se estão fora do try não tem
                //como tratar
                v1 = int.Parse(txtValor1.Text);
                v2 = int.Parse(txtValor2.Text);
                //Caso de certo ele exibe o resultado dentro do textbox
                resultado = v1 / v2;
                txtResultado.Text = resultado.ToString();
            }
            catch (DivideByZeroException) //Pega uma excessão e trata o erro
            {
                //Exibe quando da erro
                MessageBox.Show("Não é possivel divir por zero");
            }
            catch (FormatException) //trata caso o usuario tente colocar caracteres
            {
                //Executa caso o usuario
                //digite um caracter 
                MessageBox.Show("Digite apenas Números, por favor!!");
            }
            finally //Executa indepedente do que acontecer
            {
                //Aparece depois da execução
                MessageBox.Show("PROCESSO FINALIZADO...");
            }
            
            

        }

        
    }
}
