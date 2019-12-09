using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class calculadora : Form
    {
        string txt_ope = "", num = "", txt_res="", txt_num="", txt_aparecer="";
        int  tipoOpe = 0,tipoDiv=0, ponto_antes, ponto_depois,tipoSub =0, mult = 1;
        float res = 0;
        int numeroMult, numeroSub;
        bool tipoProgramador, tipoHist;
      
        public calculadora()
        {
            InitializeComponent();
            lbl_res.ResetText();
            lbl_ope.ResetText();
            ponto_depois = 0;
            ponto_antes = 0;
            tipoProgramador = false;
            tipoHist = false;
            list_histo.Visible = false;
        }

        private void Btt_n1_Click(object sender, EventArgs e)
        {
            lbl_res.Visible = true;
            txt_ope += btt_n1.Text;
            txt_res += btt_n1.Text;
            txt_num += btt_n1.Text;
            num += btt_n1.Text;
            lbl_ope.Text = txt_ope;
            txt_aparecer += btt_n1.Text;
            lbl_res.Text = txt_aparecer;
            ponto_antes = 1;
        }

        private void Bt_n2_Click(object sender, EventArgs e)
        {
            lbl_res.Visible = true;
            txt_ope += bt_n2.Text;
            txt_res += bt_n2.Text;
            txt_num += bt_n2.Text;
            num += bt_n2.Text;
            lbl_ope.Text = txt_ope;
            txt_aparecer += bt_n2.Text;
            lbl_res.Text = txt_aparecer;
            ponto_antes = 1;
        }

        private void Bt_adc_Click(object sender, EventArgs e)
        {
            tipoDiv = 1;
            if (num != "" && txt_num != "")
            {
                txt_ope += bt_adc.Text;
                if(tipoOpe== 0 || tipoOpe == 1)
                {
                    res += float.Parse(num);
                    txt_res = res.ToString();
                    tipoOpe = 1;
                    tipoSub = 1;
                    mult = 0;
                   

                }
                else if(tipoOpe == 2)
                {
                    res -= float.Parse(num);
                    txt_res = res.ToString();
                    tipoOpe = 1;
                    tipoSub = 1;
                    mult = 0;
                }
                else if(tipoOpe == 3)
                {
                    res *= float.Parse(num);
                    txt_res = res.ToString();
                    tipoOpe = 1;
                    tipoSub = 1;
                    mult = 0;
                }
                else if(tipoOpe == 4)
                {
                    if (float.Parse(num) > 0)
                    {
                        res /= float.Parse(num);
                        txt_res = res.ToString();
                        tipoOpe = 1;
                        tipoSub = 1;
                        mult = 0;
                    }
                    else
                    {
                        MessageBox.Show("divisão por zero(0) nao pode!");
                        txt_ope = "";
                        tipoDiv = 0;
                        txt_res = "";
                        tipoSub = 0;
                        mult = 1;
                        res = 0;
                        tipoOpe = 0;

                    }
                  
                }

            }
            else if(txt_res !="" && num== "" && txt_num != "")
            {
                res += float.Parse(lbl_res.Text);
                txt_res = res.ToString();
                txt_ope = res.ToString() + "+";
                tipoOpe = 1;
                tipoSub = 1;
                mult = 0;
            }
           

            lbl_ope.Text = txt_ope;
            lbl_res.Text =txt_res;
            num = "";
            txt_num = "";
            txt_aparecer = "";
            ponto_antes = 0;
            ponto_depois = 0;
        }

        private void Bt_igual_Click(object sender, EventArgs e)
        {
        
            if (num != "" && txt_num != "")
            {
                txt_ope += "=";
                if (tipoOpe == 1)
                {
                    res += float.Parse(num);
                    txt_res = res.ToString();
                }
                else if (tipoOpe == 2)
                {
                    res -= float.Parse(num);
                    txt_res = res.ToString();
                }
                else if (tipoOpe == 3)
                {
                    res *= float.Parse(num);
                    txt_res = res.ToString();
                }
                else if (tipoOpe == 4)
                {   if(float.Parse(num) > 0)
                    {
                        res /= float.Parse(num);
                        txt_res = res.ToString();
                    }
                    else
                    {
                        MessageBox.Show("divisão por zero(0) nao pode!");
                        txt_res = "";
                        txt_ope = "";
                        lbl_res.Visible = false;

                    }
                   
                }

                list_histo.Items.Add(txt_ope + txt_res);
                lbl_ope.Text = txt_ope;
                lbl_res.Text = res.ToString();
                num = "";
                res = 0;
                txt_ope = "";
                tipoOpe = 0;
                mult = 1;
                tipoSub = 0;
                txt_aparecer = "";
                ponto_antes = 0;
                ponto_depois = 0;
            }
        }
        private void Bt_n4_Click(object sender, EventArgs e)
        {
            lbl_res.Visible = true;
            txt_ope += bt_n4.Text;
            txt_res += bt_n4.Text;
            txt_num += bt_n4.Text;
            num += bt_n4.Text;
            lbl_ope.Text = txt_ope;
            txt_aparecer += bt_n4.Text;
            lbl_res.Text = txt_aparecer;
   
            ponto_antes = 1;
        }

        private void Bt_n5_Click(object sender, EventArgs e)
        {
            lbl_res.Visible = true;
            txt_ope += bt_n5.Text;
            txt_res += bt_n5.Text;
            txt_num += bt_n5.Text;
            num += bt_n5.Text;
            lbl_ope.Text = txt_ope;
            txt_aparecer += bt_n5.Text;
            lbl_res.Text = txt_aparecer;
            ponto_antes = 1;
    
        }

        private void Bt_n6_Click(object sender, EventArgs e)
        {
            lbl_res.Visible = true;
            txt_ope += bt_n6.Text;
            txt_res += bt_n6.Text;
            txt_num += bt_n6.Text;
            num += bt_n6.Text;
            lbl_ope.Text = txt_ope;
            txt_aparecer += bt_n6.Text;
            lbl_res.Text = txt_aparecer;
            ponto_antes = 1;
            
        }

        private void Bt_ponto_Click(object sender, EventArgs e)
        {
            if(ponto_antes==1 && ponto_depois == 0)
            {
                txt_aparecer += bt_ponto.Text;
                num += ",";
                txt_ope += ",";
                txt_num += ",";
                lbl_res.Text = txt_aparecer; ;
                lbl_ope.Text = txt_ope;
                ponto_antes = 0;
                ponto_depois = 1;

            }
          
        }

        private void Bt_n7_Click(object sender, EventArgs e)
        {
            lbl_res.Visible = true;
            txt_ope += bt_n7.Text;
            txt_res += bt_n7.Text;
            txt_num += bt_n7.Text;
            num += bt_n7.Text;
            lbl_ope.Text = txt_ope;
            txt_aparecer += bt_n7.Text;
            lbl_res.Text = txt_aparecer;
            ponto_antes = 1;
          
        }

        private void ProgramadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conversor con = new Conversor();
            this.Hide();
            con.Show();
        }

        private void HistoricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(tipoHist== false)
            {
                list_histo.Visible = true;
                tipoHist = true;
            }
            else
            {

                list_histo.Visible = false;
                tipoHist = false;
            }
        }

        private void Bt_n8_Click(object sender, EventArgs e)
        {
            lbl_res.Visible = true;
            txt_ope += bt_n8.Text;
            txt_res += bt_n8.Text;
            txt_num += bt_n8.Text;
            num += bt_n8.Text;
            lbl_ope.Text = txt_ope;
            txt_aparecer += bt_n8.Text;
            lbl_res.Text = txt_aparecer;
            ponto_antes = 1;

        }

        private void Bt_n9_Click(object sender, EventArgs e)
        {
            lbl_res.Visible = true;
            txt_ope += bt_n9.Text;
            txt_res += bt_n9.Text;
            txt_num += bt_n9.Text;
            num += bt_n9.Text;
            lbl_ope.Text = txt_ope;
            txt_aparecer += bt_n9.Text;
            lbl_res.Text = txt_aparecer;
            ponto_antes = 1;
    
        }

        private void List_histo_SelectedIndexChanged(object sender, EventArgs e)
        {

            ponto_antes = 1;
        }

        private void Bt_sub_Click(object sender, EventArgs e)
        {
            tipoDiv = 1;
            
            if (num != "" && txt_num != "")
            {
                txt_ope += bt_sub.Text;
                if (tipoOpe == 0 || tipoOpe == 2)
                {
                    if (tipoSub == 0)
                    {
                        res = float.Parse(num) - res;
                        tipoSub = 1;
                    }
                    else
                    {
                        res -= float.Parse(num);
                        tipoSub = 1;
                    }
                    txt_res = res.ToString();
                    mult = 0;
                    tipoOpe = 2;
                }
                else if (tipoOpe == 3)
                {
                    res *= float.Parse(num);
                    txt_res = res.ToString();
                    tipoOpe = 2;
                    tipoSub = 1;
                    mult = 0;


                }
              
                else if (tipoOpe == 1)
                {
                    res += float.Parse(num);
                    txt_res = res.ToString();
                    tipoOpe = 2;
                    tipoSub = 1;
                    mult = 0;

                }
                else if (tipoOpe == 4)
                {
                    if (float.Parse(num) > 0)
                    {
                        res /= float.Parse(num);
                        txt_res = res.ToString();
                        tipoOpe = 2;
                        tipoSub = 1;
                        mult = 0;
                    }
                    else
                    {
                        MessageBox.Show("divisão por zero(0) nao pode!");
                        txt_ope = "";
                        tipoDiv = 0;
                        txt_res = "";
                        tipoSub = 0;
                         mult = 1;
                        res = 0;
                        tipoOpe = 0;
                    }



                }


            }
            else if(txt_res != "" && num == "" && txt_num != "")
            {
                res = float.Parse(lbl_res.Text) - res;
                txt_res = res.ToString();
                txt_ope = res.ToString() + "-";
            }

            lbl_ope.Text = txt_ope;
            lbl_res.Text = txt_res;
            num = "";
            txt_num = "";
            txt_aparecer = "";
            ponto_antes = 0;
            ponto_depois = 0;
        }

        private void Bt_mult_Click(object sender, EventArgs e)
        {
          
            tipoDiv = 1;
            if (num != "" && txt_num != "")
            {

                txt_ope += bt_mult.Text;
                if (tipoOpe == 0 || tipoOpe == 3)
                {
                    if(mult == 1)
                    {
                        res = float.Parse(num) * mult;
                        mult = 0;
                    }
                    else
                    {
                        res *= float.Parse(num);
                        mult = 0;
                    }
                    txt_res = res.ToString();
                    tipoOpe = 3;
                    tipoSub = 1;
                }
                else if (tipoOpe == 4)
                {
                    if(float.Parse(num) > 0)
                    {
                        res /= float.Parse(num);
                        txt_res = res.ToString();
                        tipoOpe = 3;
                        tipoSub = 1;
                        mult = 0;
                    }
                    else
                    {
                        MessageBox.Show("divisão por zero(0) nao pode!");
                        txt_ope = "";
                        tipoDiv = 0;
                        txt_res = "";
                        mult = 1;
                        tipoSub = 0;
                        res = 0;
                        tipoOpe = 0;
                    }
                   
                }
                else if (tipoOpe == 1)
                {
                    res += float.Parse(num);
                    txt_res = res.ToString();
                    tipoOpe = 3;
                    tipoSub = 1;
                    mult = 0;
                }
                else if (tipoOpe == 2)
                {
                    res -= float.Parse(num);
                    txt_res = res.ToString();
                    tipoOpe = 3;
                    tipoSub = 1;
                    mult = 0;
                }
               
            }
            else if(txt_res != "" && num == "" && txt_num != "")
            {
                res = 1;
                res = float.Parse(lbl_res.Text) * res;
                txt_res = res.ToString();
                txt_ope = res.ToString() + "*";
                tipoSub = 1;
                mult = 0;
                tipoOpe = 3;
               
            }
            lbl_ope.Text = txt_ope;
            lbl_res.Text = txt_res;
            num = "";
            txt_num = "";
            txt_aparecer = "";
            ponto_antes = 0;
            ponto_depois = 0;
        }

        private void Bt_div_Click(object sender, EventArgs e)
        {
          

            if (num != "" && txt_num !="")
            {
                txt_ope += "/";

                if (tipoOpe == 0 || tipoOpe == 4)
                {
                    if (tipoDiv == 0)
                    {
                        res = float.Parse(num) / 1;
                        txt_res = res.ToString();
                        tipoDiv = 1;
                        tipoOpe = 4;
                    }
                    else
                    {
                        if(float.Parse(num)>0)
                        {
                            res /= float.Parse(num);
                            txt_res = res.ToString();
                            tipoDiv = 1;
                            tipoOpe = 4;
                        }
                        else
                        {
                            MessageBox.Show("divisão por zero(0) nao pode!");
                            txt_ope = "";
                            lbl_res.Text = "";
                            tipoDiv = 0;
                            txt_res = "";
                            res = 0;
                            tipoSub = 0;
                            mult = 1;
                            tipoOpe = 0;


                        }
                        
                    }
                }
                else if (tipoOpe == 1)
                {
                    res += float.Parse(num);
                    txt_res = res.ToString();
                    tipoOpe = 4;
                    tipoSub = 1;
                    mult = 0;
                }
                else if (tipoOpe == 2)
                {
                    res += float.Parse(num);
                    txt_res = res.ToString();
                    tipoOpe = 4;
                    tipoSub = 1;
                    mult = 0;
                }
                else if (tipoOpe == 3)
                {
                    res += float.Parse(num);
                    txt_res = res.ToString(); 
                    tipoOpe = 4;
                    tipoSub = 1;
                    mult = 0;
                }
            }
            else if(txt_res != "" && num == "" && txt_num != "")
            {
                res = float.Parse(lbl_res.Text) / 1;
                txt_res = res.ToString();
                txt_ope = res.ToString() + "/";
                tipoOpe = 4;
                tipoSub = 1;
                mult = 0;
                tipoDiv = 1;

            }
            lbl_ope.Text = txt_ope;
            lbl_res.Text = txt_res;
            num = "";
            txt_num = "";
            txt_aparecer = "";
            ponto_antes = 0;
            ponto_depois = 0;
        }

        private void Bt_limpar_Click(object sender, EventArgs e)
        {
          
            ponto_antes = 0;
            ponto_depois = 0;
            tipoOpe = 0;
        }

        private void Bt_n0_Click(object sender, EventArgs e)
        {
            lbl_res.Visible = true;
            txt_ope += bt_n0.Text;
            txt_res += bt_n0.Text;
            txt_num += bt_n0.Text;
            num += bt_n0.Text;
            lbl_ope.Text = txt_ope;
            txt_aparecer += bt_n0.Text;
            lbl_res.Text = txt_aparecer;
            ponto_antes = 1;
          
        }

        private void Bt_n3_Click(object sender, EventArgs e)
        {
            lbl_res.Visible = true;
            txt_ope += bt_n3.Text;
            txt_res += bt_n3.Text;
            txt_num += bt_n3.Text;
            num += bt_n3.Text;
            lbl_ope.Text = txt_ope;
            txt_aparecer += bt_n3.Text;
            lbl_res.Text = txt_aparecer;
            ponto_antes = 1;
        }



    }
}

