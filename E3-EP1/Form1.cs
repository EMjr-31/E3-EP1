using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3_EP1
{
    public partial class Form1 : Form
    {
        ////Clase Almacenadora
        numeros dato = new numeros();
        
        public Form1()
        {
            InitializeComponent();
            dato.I = 0;

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {


            ///Variables de captura de datos
            try
            {
                double num = Convert.ToDouble(txtnumeros.Text);
                if (num == 0)
                {
                    MessageBox.Show("El numero 0 no es permitido");
                    txtnumeros.Text = "";
                }
                else
                {
                    almacenar();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txtnumeros.Text = "";

        }

        private void txtnumeros_KeyPress(object sender, KeyPressEventArgs e)
        {

            ///verificar que solo sea numero y  el numero no sea negativo 
            if (Char.IsDigit(e.KeyChar))
            {
            
                e.Handled = false;

            }
            else {
                e.Handled = true;
               
                MessageBox.Show("El dato ingresado no es un numero");
            }
        }
        ///Funcion para almacenar
        public void almacenar() {        

                if (dato.I == 0) { dato.Num1 = Convert.ToInt32(txtnumeros.Text);}
                ;
                if (dato.I == 1) { dato.Num2 = Convert.ToInt32(txtnumeros.Text);}
               
                if (dato.I == 2) { dato.Num3 = Convert.ToInt32(txtnumeros.Text);}
               
                if (dato.I == 3) { dato.Num4 = Convert.ToInt32(txtnumeros.Text); }
                 
                if (dato.I == 3)
                {
                    int suma = dato.Num1 + dato.Num2 + dato.Num3 + dato.Num4;
                    if (suma >= 200) {
                    MessageBox.Show("La suma es mayor o igual a 200 ingrese de nuevo los numeros");
                    Reiniciar();
                    }
                ///Numero Mayor
                if (dato.Num1 > dato.Num2 && dato.Num1 > dato.Num3 && dato.Num1 > dato.Num4)
                {
                    if (dato.Num1 > 10)
                    {
                        dato.NumeroMayor = dato.Num1 + 10;
                    }
                }
                else {
                    if (dato.Num2 > dato.Num3 && dato.Num2 > dato.Num4)
                    {
                        if (dato.Num2 > 10)
                        {
                            dato.NumeroMayor = dato.Num2 + 10;
                        }
                        else {
                            if ( dato.Num3 > dato.Num4)
                            {
                                if (dato.Num3 > 10)
                                {
                                    dato.NumeroMayor = dato.Num3 + 10;
                                }
                                else {
                                    dato.NumeroMayor = dato.Num4 + 10;
                                }
                            }
                        }
                    }
                }
                ///Numero menor 
                if (dato.Num1 < dato.Num2 && dato.Num1 < dato.Num3 && dato.Num1 < dato.Num4)
                {
                    if (dato.Num1 <50 )
                    {
                        dato.NumeroMenor = dato.Num1 - 5;
                    }
                }
                else
                {
                    if (dato.Num2 < dato.Num3 && dato.Num2 < dato.Num4)
                    {
                        if (dato.Num2 < 50)
                        {
                            dato.NumeroMenor = dato.Num2 -5;
                        }
                        else
                        {
                            if (dato.Num3 < dato.Num4)
                            {
                                if (dato.Num3 < 50)
                                {
                                    dato.NumeroMenor = dato.Num3 -5;
                                }
                                else
                                {
                                    dato.NumeroMenor = dato.Num4 -5;
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Los numeros ingresados son: " + dato.Num1.ToString() + "," + dato.Num2.ToString() + "," + dato.Num3.ToString() + "," + dato.Num4.ToString() + " el numero mayor es: "+dato.NumeroMayor.ToString()+", el numero menor es: "+dato.NumeroMenor.ToString());
            }
            dato.I++;
        }
        ///Funcion Reiniciar todo
        public void Reiniciar() {
            dato.I = 0;
        }
    }
}
