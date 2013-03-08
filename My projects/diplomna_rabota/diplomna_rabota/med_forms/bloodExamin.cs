using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace diplomna_rabota.med_forms
{
    public partial class bloodExamin : Form
    {
        public bloodExamin()
        {
            InitializeComponent();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedItem.ToString() == "ALAT")
            {
                label1.Show();
                alat.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Албумин")
            {
                albumin.Show();
                label2.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Алкална фосфатаза")
            {
                label3.Show();
                alkalFos.Show();
            }
            if (checkedListBox1.SelectedItem.ToString() == "Амилаза")
            {
                label4.Show();
                amil.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "ASAT")
            {
                label5.Show();
                asat.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Бикарбонат")
            {
                label6.Show();
                bikar.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Билирубин-общ")
            {
                label5.Show();
                obilir.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Билирубин-директен")
            {
                label5.Show();
                dbilir.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Време кървене")
            {
                label5.Show();
                bloodT.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Кисела фосфатаза")
            {
                label6.Show();
                bloodT.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "BUN")
            {
                label8.Show();
                bun.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "MCV")
            {
                label9.Show();
                bun.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Na+")
            {
                label10.Show();
                na.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "CEA")
            {
                label11.Show();
                cea.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "CEA-125")
            {
                label11.Show();
                cea125.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "CA 15-3")
            {
                label11.Show();
                ca15.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "CA19-9")
            {
                label11.Show();
                ca19.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "D dimer")
            {
                label11.Show();
                ca19.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Кръвна захар")
            {
                label11.Show();
                glucose.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "HDL")
            {
                label11.Show();
                hdl.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "IgM")
            {
                label11.Show();
                igm.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "IgG")
            {
                label11.Show();
                igg.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "IgA")
            {
                label11.Show();
                iga.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "VIT B 12")
            {
                label11.Show();
                vitb.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Fe")
            {
                label11.Show();
                fe.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Fe")
            {
                label11.Show();
                jsk.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Fe")
            {
                label11.Show();
                jsk.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "K+")
            {
                label11.Show();
                kalii.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Ca 2+")
            {
                label11.Show();
                kalcii.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Кетони в урината")
            {
                label11.Show();
                ketoni.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Hb")
            {
                label11.Show();
                hb.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "CPK")
            {
                label11.Show();
                cpk.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "LDH")
            {
                label11.Show();
                ldh.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Креатинин")
            {
                label11.Show();
                kreatin.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Креатининов клиърънс")
            {
                label11.Show();
                kreatinKl.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "WBC")
            {
                label11.Show();
                wbc.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Микроалбуминурия")
            {
                label11.Show();
                microAl.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Парциално тромбопластиново време")
            {
                label11.Show();
                aptt.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Общ белтък(TPROT)")
            {
                label11.Show();
                tprot.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Парц. Р CO2")
            {
                label11.Show();
                parPC.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Пикочна киселина")
            {
                label11.Show();
                pikKS.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "PSA")
            {
                label11.Show();
                psa.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "ALFA1 GLOBULIN")
            {
                label11.Show();
                alfa1.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "ALFA2 GLOBULIN")
            {
                label11.Show();
                alfa2.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "BETA GLOBULIN")
            {
                label11.Show();
                beta.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "GAMMA GLOBULIN")
            {
                label11.Show();
                gama.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Протромбиново време")
            {
                label11.Show();
                protrom.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Ретикулоцити")
            {
                label11.Show();
                retikul.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "FT4")
            {
                label11.Show();
                ft4.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "FT3")
            {
                label11.Show();
                ft3.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Трансферин")
            {
                label11.Show();
                transfer.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "TAG")
            {
                label11.Show();
                tag.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "PLT")
            {
                label11.Show();
                plt.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Уробилиноген")
            {
                label11.Show();
                urobi.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Феритин")
            {
                label11.Show();
                feritin.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Фибриноген")
            {
                label11.Show();
                fibri.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Hct")
            {
                label11.Show();
                hct.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Церулоплазмин")
            {
                label11.Show();
                cerulo.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Hb A 1c")
            {
                label11.Show();
                hba1.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Hb A 2")
            {
                label11.Show();
                hba2.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Cholesterol")
            {
                label11.Show();
                choles.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "LDL")
            {
                label11.Show();
                ldl.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Урея")
            {
                label11.Show();
                urea.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Sat O2")
            {
                label11.Show();
                sato2.Show();
            }
            if (checkedListBox1.SelectedItem.ToString() == "Урея-жени")
            {
                label11.Show();
                ureaW.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "NH3")
            {
                label11.Show();
                nh3.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Антитиреоидна пероксидаза")
            {
                label11.Show();
                atp.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Мед")
            {
                label11.Show();
                med.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Феритин-жени")
            {
                label11.Show();
                feritinW.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Липаза")
            {
                label11.Show();
                lipaza.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "СУЕ")
            {
                label11.Show();
                sue.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "NSE")
            {
                 nse.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "CA 72-4")
            {
                 ca72.Show();
            }


            if (checkedListBox1.SelectedItem.ToString() == "SCC")
            {
                label11.Show();
                scc.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "НЕУТРОФИЛИ")
            {
                label11.Show();
                neutro.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "МОНОЦИТИ")
            {
                label11.Show();
                mono.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "ЛИМФОЦИТИ")
            {
                label11.Show();
                limfo.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "ЕОЗИНОФИЛИ")
            {
                label11.Show();
                eozino.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "БАЗОФИЛИ")
            {
                label11.Show();
                bazof.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "НЕУТРОФИЛИ-брой")
            {
                label11.Show();
                neotrof.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "INR")
            {
                label11.Show();
                inr.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "MCH")
            {
                label11.Show();
                mch.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "CPK-MB")
            {
                label11.Show();
                cpkm.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "MCHC")
            {
                label11.Show();
                mchc.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "АКТУАЛНИ БИКАРБОНАТИ")
            {
                label11.Show();
                birarb.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "БУФЕРНИ БАЗИ")
            {
                label11.Show();
                baziB.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "СТАНДАРТНИ БАЗИ")
            {
                label11.Show();
                baziS.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "ВЕ")
            {
                label11.Show();
                be.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "BNP")
            {
                label11.Show();
                bnp.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "Npro BNP")
            {
                label11.Show();
                npro.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "CIFRA")
            {
                label11.Show();
                cifra.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "CRP")
            {
                label11.Show();
                crp.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "RBC")
            {
                label11.Show();
                rbc.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "b-HHG")
            {
                label11.Show();
                bhh.Show();
            }

            if (checkedListBox1.SelectedItem.ToString() == "P O2")
            {
                label11.Show();
                po2.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if ((alat.Visible == true))
                {
                    int _alat = Int32.Parse(alat.Text);

                    if ((_alat >= 5) && (_alat <= 40))
                    {
                        alat.Text = "в нормата";
                    }

                    if (_alat < 5)
                    {
                        alat.Text = "ниско";
                    }

                    if ((_alat > 40))
                    {
                        alat.Text = "високо";
                    }
                }

                if ((albumin.Visible == true))
                {
                    int _albumin = Int32.Parse(albumin.Text);

                    if ((_albumin >= 35) && (_albumin <= 50))
                    {
                        albumin.Text = "в нормата";
                    }

                    if (_albumin < 35)
                    {
                        albumin.Text = "ниско";
                    }

                    if ((_albumin > 50))
                    {
                        albumin.Text = "високо";
                    }

                }

                if ((alkalFos.Visible == true))
                {
                    int _alkalFos = Int32.Parse(alkalFos.Text);

                    if ((_alkalFos >= 70) && (_alkalFos <= 300))
                    {
                        alkalFos.Text = "в нормата";
                    }

                    if (_alkalFos < 70)
                    {
                        alkalFos.Text = "ниско";
                    }

                    if ((_alkalFos > 300))
                    {
                        alkalFos.Text = "високо";
                    }
                }

                if ((amil.Visible == true))
                {
                    int _amil = Int32.Parse(amil.Text);

                    if ((_amil >= 0) && (_amil <= 220))
                    {
                        amil.Text = "в нормата";
                    }

                    if ((_amil > 220))
                    {
                        amil.Text = "високо";
                    }
                }

                if ((asat.Visible == true))
                {
                    int _asat = Int32.Parse(asat.Text);

                    if ((_asat >= 5) && (_asat <= 40))
                    {
                        asat.Text = "в нормата";
                    }

                    if (_asat < 5)
                    {
                        asat.Text = "ниско";
                    }

                    if ((_asat > 40))
                    {
                        asat.Text = "високо";
                    }
                }

                if ((bikar.Visible == true))
                {
                    int _bikar = Int32.Parse(bikar.Text);

                    if ((_bikar >= 21) && (_bikar <= 25))
                    {
                        bikar.Text = "в нормата";
                    }

                    if (_bikar < 21)
                    {
                        bikar.Text = "ниско";
                    }

                    if ((_bikar > 25))
                    {
                        bikar.Text = "високо";
                    }
                }

                if ((obilir.Visible == true))
                {
                    int _obilir = Int32.Parse(obilir.Text);

                    if ((_obilir >= 5) && (_obilir <= 23))
                    {
                        obilir.Text = "в нормата";
                    }

                    if (_obilir < 5)
                    {
                        obilir.Text = "ниско";
                    }

                    if ((_obilir > 23))
                    {
                        obilir.Text = "високо";
                    }

                }

                if ((dbilir.Visible == true))
                {
                    double _dbilir = Double.Parse(dbilir.Text);

                    if ((_dbilir >= 0.8) && (_dbilir <= 8.5))
                    {
                        dbilir.Text = "в нормата";
                    }

                    if (_dbilir < 0.8)
                    {
                        dbilir.Text = "ниско";
                    }

                    if ((_dbilir > 8.5))
                    {
                        dbilir.Text = "високо";
                    }

                }

                if ((bloodT.Visible == true))
                {
                    int _bloodT = Int32.Parse(bloodT.Text);

                    if ((_bloodT >= 2) && (_bloodT <= 5))
                    {
                        bloodT.Text = "в нормата";
                    }

                    if (_bloodT < 2)
                    {
                        bloodT.Text = "ниско";
                    }

                    if ((_bloodT > 5))
                    {
                        bloodT.Text = "високо";
                    }
                }

                if ((fosK.Visible == true))
                {
                    double _fosK = Double.Parse(fosK.Text);

                    if ((_fosK >= 0) && (_fosK <= 6.5))
                    {
                        fosK.Text = "в нормата";
                    }

                    if ((_fosK > 6.5))
                    {
                        fosK.Text = "високо";
                    }
                }

                if ((bun.Visible == true))
                {
                    double _bun = Double.Parse(bun.Text);

                    if ((_bun >= 2.9) && (_bun <= 7.9))
                    {
                        bun.Text = "в нормата";
                    }

                    if (_bun < 2.9)
                    {
                        bun.Text = "ниско";
                    }

                    if ((_bun > 7.9))
                    {
                        bun.Text = "високо";
                    }
                }

                if ((mcv.Visible == true))
                {
                    int _mcv = Int32.Parse(mcv.Text);

                    if ((_mcv >= 80) && (_mcv <= 96))
                    {
                        mcv.Text = "в нормата";
                    }

                    if (_mcv < 80)
                    {
                        mcv.Text = "ниско";
                    }

                    if ((_mcv > 96))
                    {
                        mcv.Text = "високо";
                    }
                }

                if ((na.Visible == true))
                {
                    int _na = Int32.Parse(na.Text);

                    if ((_na >= 135) && (_na <= 143))
                    {
                        na.Text = "в нормата";
                    }

                    if (_na < 135)
                    {
                        na.Text = "ниско";
                    }

                    if ((_na > 143))
                    {
                        na.Text = "високо";
                    }
                }

                if ((cea.Visible == true))
                {
                    int _cea = Int32.Parse(cea.Text);

                    if ((_cea >= 0) && (_cea <= 5))
                    {
                        cea.Text = "в нормата";
                    }

                    if ((_cea > 5))
                    {
                        cea.Text = "високо";
                    }
                }

                if ((cea125.Visible == true))
                {
                    int _cea125 = Int32.Parse(cea125.Text);

                    if ((_cea125 >= 0) && (_cea125 <= 35))
                    {
                        cea125.Text = "в нормата";
                    }

                    if ((_cea125 > 35))
                    {
                        cea125.Text = "високо";
                    }
                }

                if ((ca15.Visible == true))
                {
                    int _ca15 = Int32.Parse(ca15.Text);

                    if ((_ca15 >= 0) && (_ca15 <= 28))
                    {
                        ca15.Text = "в нормата";
                    }

                    if ((_ca15 > 28))
                    {
                        ca15.Text = "високо";
                    }
                }

                if ((ca19.Visible == true))
                {
                    int _ca19 = Int32.Parse(ca19.Text);

                    if ((_ca19 >= 0) && (_ca19 <= 28))
                    {
                        ca19.Text = "в нормата";
                    }

                    if ((_ca19 > 28))
                    {
                        ca19.Text = "високо";
                    }
                }

                if ((dimer.Visible == true))
                {
                    int _dimer = Int32.Parse(dimer.Text);

                    if ((_dimer >= 0) && (_dimer <= 20))
                    {
                        dimer.Text = "в нормата";
                    }

                    if ((_dimer > 20))
                    {
                        dimer.Text = "високо";
                    }
                }

                if ((glucose.Visible == true))
                {
                    double _glucose = Double.Parse(glucose.Text);

                    if ((_glucose >= 2.9) && (_glucose <= 7.9))
                    {
                        glucose.Text = "в нормата";
                    }

                    if (_glucose < 2.9)
                    {
                        glucose.Text = "ниско";
                    }

                    if ((_glucose > 7.9))
                    {
                        glucose.Text = "високо";
                    }
                }

                if ((hdl.Visible == true))
                {
                    double _hdl = Double.Parse(hdl.Text);

                    if (_hdl >= 2.9)
                    {
                        hdl.Text = "в нормата";
                    }

                    if (_hdl < 2.9)
                    {
                        hdl.Text = "ниско";
                    }
                }

                if ((igm.Visible == true))
                {
                    double _igm = Double.Parse(igm.Text);

                    if ((_igm >= 0.5) && (_igm <= 3.0))
                    {
                        igm.Text = "в нормата";
                    }

                    if (_igm < 0.5)
                    {
                        igm.Text = "ниско";
                    }

                    if (_igm > 3.0)
                    {
                        igm.Text = "високо";
                    }
                }

                if ((igg.Visible == true))
                {
                    int _igg = Int32.Parse(igg.Text);

                    if ((_igg >= 5) && (_igg <= 17))
                    {
                        igg.Text = "в нормата";
                    }

                    if (_igg < 5)
                    {
                        igg.Text = "ниско";
                    }

                    if (_igg > 17)
                    {
                        igg.Text = "високо";
                    }
                }

                if ((iga.Visible == true))
                {
                    double _iga = Double.Parse(iga.Text);

                    if ((_iga >= 1.0) && (_iga <= 4.5))
                    {
                        iga.Text = "в нормата";
                    }

                    if (_iga < 1.0)
                    {
                        iga.Text = "ниско";
                    }

                    if (_iga > 4.5)
                    {
                        iga.Text = "високо";
                    }
                }

                if ((lfp.Visible == true))
                {
                    int _lfp = Int32.Parse(lfp.Text);

                    if ((_lfp >= 0) && (_lfp <= 70))
                    {
                        lfp.Text = "в нормата";
                    }
                    if (_lfp > 70)
                    {
                        lfp.Text = "високо";
                    }
                }

                if ((vitb.Visible == true))
                {
                    int _vitb = Int32.Parse(vitb.Text);

                    if ((_vitb >= 136) && (_vitb <= 1100))
                    {
                        vitb.Text = "в нормата";
                    }

                    if (_vitb < 136)
                    {
                        vitb.Text = "ниско";
                    }

                    if (_vitb > 1100)
                    {
                        vitb.Text = "високо";
                    }
                }

                if ((fe.Visible == true))
                {
                    double _fe = Double.Parse(fe.Text);

                    if ((_fe >= 12.6) && (_fe <= 26.0))
                    {
                        fe.Text = "в нормата";
                    }

                    if (_fe < 12.6)
                    {
                        fe.Text = "ниско";
                    }

                    if (_fe > 26.0)
                    {
                        fe.Text = "високо";
                    }
                }

                if ((jsk.Visible == true))
                {
                    int _jsk = Int32.Parse(jsk.Text);

                    if ((_jsk >= 44) && (_jsk <= 66))
                    {
                        jsk.Text = "в нормата";
                    }

                    if (_jsk < 44)
                    {
                        jsk.Text = "ниско";
                    }

                    if (_jsk > 66)
                    {
                        jsk.Text = "високо";
                    }
                }

                if ((kalii.Visible == true))
                {
                    double _kalii = Double.Parse(kalii.Text);

                    if ((_kalii >= 3.5) && (_kalii <= 5.5))
                    {
                        kalii.Text = "в нормата";
                    }

                    if (_kalii < 3.5)
                    {
                        kalii.Text = "ниско";
                    }

                    if (_kalii > 5.5)
                    {
                        kalii.Text = "високо";
                    }
                }

                if ((kalcii.Visible == true))
                {
                    double _kalcii = Double.Parse(kalcii.Text);

                    if ((_kalcii >= 2.23) && (_kalcii <= 2.63))
                    {
                        kalcii.Text = "в нормата";
                    }

                    if (_kalcii < 2.23)
                    {
                        kalcii.Text = "ниско";
                    }

                    if (_kalcii > 2.63)
                    {
                        kalcii.Text = "високо";
                    }
                }

                if ((hlor.Visible == true))
                {
                    int _hlor = Int32.Parse(hlor.Text);

                    if ((_hlor >= 100) && (_hlor <= 109))
                    {
                        hlor.Text = "в нормата";
                    }

                    if (_hlor < 100)
                    {
                        hlor.Text = "ниско";
                    }

                    if (_hlor > 109)
                    {
                        hlor.Text = "високо";
                    }
                }

                if ((ketoni.Visible == true))
                {
                    int _ketoni = Int32.Parse(ketoni.Text);

                    if (_ketoni <= 1)
                    {
                        ketoni.Text = "в нормата";
                    }

                    if (_ketoni > 1)
                    {
                        ketoni.Text = "високо";
                    }
                }

                if ((hb.Visible == true))
                {
                    int _hb = Int32.Parse(hb.Text);

                    if ((_hb >= 132) && (_hb <= 173))
                    {
                        hb.Text = "в нормата";
                    }

                    if (_hb < 132)
                    {
                        hb.Text = "ниско";
                    }

                    if (_hb > 173)
                    {
                        hb.Text = "високо";
                    }
                }

                if ((cpk.Visible == true))
                {
                    int _cpk = Int32.Parse(cpk.Text);

                    if ((_cpk >= 50) && (_cpk <= 300))
                    {
                        cpk.Text = "в нормата";
                    }

                    if (_cpk < 50)
                    {
                        cpk.Text = "ниско";
                    }

                    if (_cpk > 300)
                    {
                        cpk.Text = "високо";
                    }
                }

                if ((ldh.Visible == true))
                {
                    int _ldh = Int32.Parse(ldh.Text);

                    if ((_ldh >= 120) && (_ldh <= 240))
                    {
                        ldh.Text = "в нормата";
                    }

                    if (_ldh < 120)
                    {
                        ldh.Text = "ниско";
                    }

                    if (_ldh > 240)
                    {
                        ldh.Text = "високо";
                    }
                }

                if ((kreatin.Visible == true))
                {
                    int _kreatin = Int32.Parse(kreatin.Text);

                    if ((_kreatin >= 74) && (_kreatin <= 110))
                    {
                        kreatin.Text = "в нормата";
                    }

                    if (_kreatin < 74)
                    {
                        kreatin.Text = "ниско";
                    }

                    if (_kreatin > 110)
                    {
                        kreatin.Text = "високо";
                    }
                }

                if ((kreatinKl.Visible == true))
                {
                    int _kreatinKl = Int32.Parse(kreatinKl.Text);

                    if ((_kreatinKl >= 70) && (_kreatinKl <= 120))
                    {
                        kreatinKl.Text = "в нормата";
                    }

                    if (_kreatinKl < 70)
                    {
                        kreatinKl.Text = "ниско";
                    }

                    if (_kreatinKl > 120)
                    {
                        kreatinKl.Text = "високо";
                    }
                }


                if ((wbc.Visible == true))
                {
                    double _wbc = Double.Parse(wbc.Text);

                    if ((_wbc >= 3.5) && (_wbc <= 10.5))
                    {
                        wbc.Text = "в нормата";
                    }

                    if (_wbc < 3.5)
                    {
                        wbc.Text = "ниско";
                    }

                    if (_wbc > 10.5)
                    {
                        wbc.Text = "високо";
                    }
                }

                if ((microAl.Visible == true))
                {
                    int _microAl = Int32.Parse(microAl.Text);

                    if ((_microAl >= 0) && (_microAl <= 40))
                    {
                        microAl.Text = "в нормата";
                    }

                    if (_microAl > 40)
                    {
                        microAl.Text = "високо";
                    }
                }

                if ((aptt.Visible == true))
                {
                    int _aptt = Int32.Parse(aptt.Text);

                    if ((_aptt >= 22) && (_aptt <= 33))
                    {
                        aptt.Text = "в нормата";
                    }

                    if (_aptt < 22)
                    {
                        aptt.Text = "ниско";
                    }

                    if (_aptt > 33)
                    {
                        aptt.Text = "високо";
                    }
                }

                if ((tprot.Visible == true))
                {
                    int _tprot = Int32.Parse(tprot.Text);

                    if ((_tprot >= 60) && (_tprot <= 85))
                    {
                        tprot.Text = "в нормата";
                    }

                    if (_tprot < 60)
                    {
                        tprot.Text = "ниско";
                    }

                    if (_tprot > 85)
                    {
                        tprot.Text = "високо";
                    }
                }

                if ((parPC.Visible == true))
                {
                    int _parPC = Int32.Parse(parPC.Text);

                    if ((_parPC >= 36) && (_parPC <= 44))
                    {
                        parPC.Text = "в нормата";
                    }

                    if (_parPC < 36)
                    {
                        parPC.Text = "ниско";
                    }

                    if (_parPC > 44)
                    {
                        parPC.Text = "високо";
                    }
                }

                if ((pikKS.Visible == true))
                {
                    int _pikKS = Int32.Parse(pikKS.Text);

                    if ((_pikKS >= 180) && (_pikKS <= 410))
                    {
                        pikKS.Text = "в нормата";
                    }

                    if (_pikKS < 180)
                    {
                        pikKS.Text = "ниско";
                    }

                    if (_pikKS > 410)
                    {
                        pikKS.Text = "високо";
                    }
                }

                if ((psa.Visible == true))
                {
                    int _psa = Int32.Parse(psa.Text);

                    if ((_psa >= 0) && (_psa <= 4))
                    {
                        psa.Text = "в нормата";
                    }

                    if (_psa > 4)
                    {
                        psa.Text = "високо";
                    }
                }

                if ((alfa1.Visible == true))
                {
                    int _alfa1 = Int32.Parse(alfa1.Text);

                    if ((_alfa1 >= 1) && (_alfa1 <= 3))
                    {
                        alfa1.Text = "в нормата";
                    }

                    if (_alfa1 < 1)
                    {
                        alfa1.Text = "ниско";
                    }

                    if (_alfa1 > 3)
                    {
                        alfa1.Text = "високо";
                    }
                }

                if ((alfa2.Visible == true))
                {
                    int _alfa2 = Int32.Parse(alfa2.Text);

                    if ((_alfa2 >= 6) && (_alfa2 <= 10))
                    {
                        alfa2.Text = "в нормата";
                    }

                    if (_alfa2 < 6)
                    {
                        alfa2.Text = "ниско";
                    }

                    if (_alfa2 > 10)
                    {
                        alfa2.Text = "високо";
                    }
                }
                if ((beta.Visible == true))
                {
                    int _beta = Int32.Parse(beta.Text);

                    if ((_beta >= 7) && (_beta <= 11))
                    {
                        beta.Text = "в нормата";
                    }

                    if (_beta < 7)
                    {
                        beta.Text = "ниско";
                    }

                    if (_beta > 11)
                    {
                        beta.Text = "високо";
                    }
                }

                if ((gama.Visible == true))
                {
                    int _gama = Int32.Parse(beta.Text);

                    if ((_gama >= 8) && (_gama <= 16))
                    {
                        gama.Text = "в нормата";
                    }

                    if (_gama < 8)
                    {
                        gama.Text = "ниско";
                    }

                    if (_gama > 16)
                    {
                        gama.Text = "високо";
                    }
                }
                if ((protrom.Visible == true))
                {
                    int _protrom = Int32.Parse(protrom.Text);

                    if ((_protrom >= 11) && (_protrom <= 15))
                    {
                        protrom.Text = "в нормата";
                    }

                    if (_protrom < 11)
                    {
                        protrom.Text = "ниско";
                    }

                    if (_protrom > 15)
                    {
                        protrom.Text = "високо";
                    }
                }

                if ((retikul.Visible == true))
                {
                    int _retikul = Int32.Parse(retikul.Text);

                    if ((_retikul >= 24) && (_retikul <= 84))
                    {
                        retikul.Text = "в нормата";
                    }

                    if (_retikul < 24)
                    {
                        retikul.Text = "ниско";
                    }

                    if (_retikul > 84)
                    {
                        retikul.Text = "високо";
                    }
                }

                if ((ft4.Visible == true))
                {
                    double _ft4 = Double.Parse(ft4.Text);

                    if ((_ft4 >= 9.0) && (_ft4 <= 19.4))
                    {
                        ft4.Text = "в нормата";
                    }

                    if (_ft4 < 9.0)
                    {
                        ft4.Text = "ниско";
                    }

                    if (_ft4 > 19.4)
                    {
                        ft4.Text = "високо";
                    }
                }

                if ((ft3.Visible == true))
                {
                    double _ft3 = Double.Parse(ft3.Text);

                    if ((_ft3 >= 2.9) && (_ft3 <= 7.7))
                    {
                        ft3.Text = "в нормата";
                    }

                    if (_ft3 < 2.7)
                    {
                        ft3.Text = "ниско";
                    }

                    if (_ft3 > 7.7)
                    {
                        ft3.Text = "високо";
                    }
                }

                if ((transfer.Visible == true))
                {
                    double _transfer = Double.Parse(transfer.Text);

                    if ((_transfer >= 2.15) && (_transfer <= 3.75))
                    {
                        transfer.Text = "в нормата";
                    }

                    if (_transfer < 2.15)
                    {
                        transfer.Text = "ниско";
                    }

                    if (_transfer > 3.75)
                    {
                        transfer.Text = "високо";
                    }
                }

                if ((tag.Visible == true))
                {
                    double _tag = Double.Parse(tag.Text);

                    if (_tag <= 2.26)
                    {
                        tag.Text = "в нормата";
                    }

                    if (_tag > 2.26)
                    {
                        tag.Text = "високо";
                    }
                }

                if ((plt.Visible == true))
                {
                    int _plt = Int32.Parse(plt.Text);

                    if ((_plt >= 150) && (_plt <= 350))
                    {
                        plt.Text = "в нормата";
                    }

                    if (_plt < 150)
                    {
                        plt.Text = "ниско";
                    }

                    if (_plt > 350)
                    {
                        plt.Text = "високо";
                    }
                }

                if ((urobi.Visible == true))
                {
                    int _urobi = Int32.Parse(urobi.Text);

                    if ((_urobi >= 0) && (_urobi <= 1))
                    {
                        urobi.Text = "в нормата";
                    }

                    if (_urobi > 1)
                    {
                        urobi.Text = "високо";
                    }
                }

                if ((feritin.Visible == true))
                {
                    int _feritin = Int32.Parse(feritin.Text);

                    if ((_feritin >= 20) && (_feritin <= 280))
                    {
                        feritin.Text = "в нормата";
                    }

                    if (_feritin < 20)
                    {
                        feritin.Text = "ниско";
                    }

                    if (_feritin > 280)
                    {
                        feritin.Text = "високо";
                    }
                }

                if ((fibri.Visible == true))
                {
                    int _fibri = Int32.Parse(fibri.Text);

                    if ((_fibri >= 2) && (_fibri <= 4))
                    {
                        fibri.Text = "в нормата";
                    }

                    if (_fibri < 2)
                    {
                        fibri.Text = "ниско";
                    }

                    if (_fibri > 4)
                    {
                        fibri.Text = "високо";
                    }
                }

                if ((hct.Visible == true))
                {
                    int _hct = Int32.Parse(hct.Text);

                    if ((_hct >= 39) && (_hct <= 49))
                    {
                        hct.Text = "в нормата";
                    }

                    if (_hct < 39)
                    {
                        hct.Text = "ниско";
                    }

                    if (_hct > 49)
                    {
                        hct.Text = "високо";
                    }
                }

                if ((cerulo.Visible == true))
                {
                    double _cerulo = Double.Parse(cerulo.Text);

                    if ((_cerulo >= 0.15) && (_cerulo <= 0.6))
                    {
                        cerulo.Text = "в нормата";
                    }

                    if (_cerulo < 0.15)
                    {
                        cerulo.Text = "ниско";
                    }

                    if (_cerulo > 0.6)
                    {
                        cerulo.Text = "високо";
                    }
                }

                if ((hba1.Visible == true))
                {
                    double _hba1 = Double.Parse(hba1.Text);

                    if (_hba1 <= 7.25)
                    {
                        hba1.Text = "в нормата";
                    }

                    if (_hba1 > 7.25)
                    {
                        hba1.Text = "високо";
                    }
                }

                if ((hba2.Visible == true))
                {
                    double _hba2 = Double.Parse(hba2.Text);

                    if ((_hba2 >= 1.5) && (_hba2 <= 3.5))
                    {
                        hba2.Text = "в нормата";
                    }

                    if (_hba2 < 1.5)
                    {
                        hba2.Text = "ниско";
                    }

                    if (_hba2 > 3.5)
                    {
                        hba2.Text = "високо";
                    }
                }

                if ((choles.Visible == true))
                {
                    double _choles = Double.Parse(choles.Text);

                    if (_choles <= 5.2)
                    {
                        choles.Text = "в нормата";
                    }

                    if (_choles > 5.2)
                    {
                        choles.Text = "високо";
                    }
                }

                if ((ldl.Visible == true))
                {
                    double _ldl = Double.Parse(ldl.Text);

                    if (_ldl <= 3.4)
                    {
                        ldl.Text = "в нормата";
                    }

                    if (_ldl > 3.4)
                    {
                        ldl.Text = "високо";
                    }
                }

                if ((urea.Visible == true))
                {
                    double _urea = Double.Parse(urea.Text);

                    if ((_urea >= 3.2) && (_urea <= 9.2))
                    {
                        urea.Text = "в нормата";
                    }

                    if (_urea < 3.2)
                    {
                        urea.Text = "ниско";
                    }

                    if (_urea > 9.2)
                    {
                        urea.Text = "високо";
                    }
                }

                if ((sato2.Visible == true))
                {
                    int _sato2 = Int32.Parse(sato2.Text);

                    if ((_sato2 >= 94) && (_sato2 <= 98))
                    {
                        sato2.Text = "в нормата";
                    }

                    if (_sato2 < 94)
                    {
                        sato2.Text = "ниско";
                    }

                    if (_sato2 > 98)
                    {
                        sato2.Text = "високо";
                    }
                }

                if ((ureaW.Visible == true))
                {
                    double _ureaW = Double.Parse(ureaW.Text);

                    if ((_ureaW >= 2.6) && (_ureaW <= 5.2))
                    {
                        ureaW.Text = "в нормата";
                    }

                    if (_ureaW < 2.6)
                    {
                        ureaW.Text = "ниско";
                    }

                    if (_ureaW > 5.2)
                    {
                        ureaW.Text = "високо";
                    }
                }

                if ((nh3.Visible == true))
                {
                    int _nh3 = Int32.Parse(nh3.Text);

                    if ((_nh3 >= 10) && (_nh3 <= 47))
                    {
                        nh3.Text = "в нормата";
                    }

                    if (_nh3 < 10)
                    {
                        nh3.Text = "ниско";
                    }

                    if (_nh3 > 47)
                    {
                        nh3.Text = "високо";
                    }
                }

                if ((atp.Visible == true))
                {
                    double _atp = Double.Parse(atp.Text);

                    if ((_atp >= 0.0) && (_atp <= 0.3))
                    {
                        atp.Text = "в нормата";
                    }

                    if (_atp > 0.3)
                    {
                        atp.Text = "високо";
                    }
                }

                if ((med.Visible == true))
                {
                    int _med = Int32.Parse(med.Text);

                    if ((_med >= 11) && (_med <= 24))
                    {
                        med.Text = "в нормата";
                    }

                    if (_med < 11)
                    {
                        med.Text = "ниско";
                    }

                    if (_med > 24)
                    {
                        med.Text = "високо";
                    }
                }

                if ((feritinW.Visible == true))
                {
                    int _feritinW = Int32.Parse(feritinW.Text);

                    if ((_feritinW >= 10) && (_feritinW <= 140))
                    {
                        feritinW.Text = "в нормата";
                    }

                    if (_feritinW < 10)
                    {
                        feritinW.Text = "ниско";
                    }

                    if (_feritinW > 140)
                    {
                        feritinW.Text = "високо";
                    }
                }

                if ((lipaza.Visible == true))
                {
                    int _lipaza = Int32.Parse(lipaza.Text);

                    if ((_lipaza >= 50) && (_lipaza <= 220))
                    {
                        lipaza.Text = "в нормата";
                    }

                    if (_lipaza < 50)
                    {
                        lipaza.Text = "ниско";
                    }

                    if (_lipaza > 220)
                    {
                        lipaza.Text = "високо";
                    }
                }


                if ((sue.Visible == true))
                {
                    int _sue = Int32.Parse(sue.Text);

                    if ((_sue >= 0) && (_sue <= 20))
                    {
                        sue.Text = "в нормата";
                    }

                    if (_sue > 20)
                    {
                        sue.Text = "високо";
                    }
                }

                if ((nse.Visible == true))
                {
                    int _nse = Int32.Parse(nse.Text);

                    if ((_nse >= 0) && (_nse <= 13))
                    {
                        nse.Text = "в нормата";
                    }

                    if (_nse > 13)
                    {
                        nse.Text = "високо";
                    }
                }

                if ((ca72.Visible == true))
                {
                    int _ca72 = Int32.Parse(ca72.Text);

                    if ((_ca72 >= 0) && (_ca72 <= 6))
                    {
                        ca72.Text = "в нормата";
                    }

                    if (_ca72 > 6)
                    {
                        ca72.Text = "високо";
                    }
                }

                if ((scc.Visible == true))
                {
                    double _scc = Double.Parse(scc.Text);

                    if ((_scc >= 0.0) && (_scc <= 1.5))
                    {
                        scc.Text = "в нормата";
                    }

                    if (_scc > 1.5)
                    {
                        scc.Text = "високо";
                    }
                }

                if ((neutro.Visible == true))
                {
                    int _neutro = Int32.Parse(neutro.Text);

                    if ((_neutro >= 40) && (_neutro <= 70))
                    {
                        neutro.Text = "в нормата";
                    }

                    if (_neutro < 40)
                    {
                        neutro.Text = "ниско";
                    }

                    if (_neutro > 70)
                    {
                        neutro.Text = "високо";
                    }
                }

                if ((mono.Visible == true))
                {
                    int _mono = Int32.Parse(mono.Text);

                    if ((_mono >= 1) && (_mono <= 11))
                    {
                        mono.Text = "в нормата";
                    }

                    if (_mono < 1)
                    {
                        mono.Text = "ниско";
                    }

                    if (_mono > 11)
                    {
                        mono.Text = "високо";
                    }
                }

                if ((limfo.Visible == true))
                {
                    int _limfo = Int32.Parse(limfo.Text);

                    if ((_limfo >= 20) && (_limfo <= 48))
                    {
                        limfo.Text = "в нормата";
                    }

                    if (_limfo < 20)
                    {
                        limfo.Text = "ниско";
                    }

                    if (_limfo > 48)
                    {
                        limfo.Text = "високо";
                    }
                }

                if ((eozino.Visible == true))
                {
                    int _eozino = Int32.Parse(eozino.Text);

                    if ((_eozino >= 0) && (_eozino <= 6))
                    {
                        eozino.Text = "в нормата";
                    }

                    if (_eozino > 6)
                    {
                        eozino.Text = "високо";
                    }
                }

                if ((bazof.Visible == true))
                {
                    int _bazof = Int32.Parse(bazof.Text);

                    if ((_bazof >= 0) && (_bazof <= 2))
                    {
                        bazof.Text = "в нормата";
                    }

                    if (_bazof > 2)
                    {
                        bazof.Text = "високо";
                    }
                }

                if ((neotrof.Visible == true))
                {
                    double _neotrof = Double.Parse(neotrof.Text);

                    if ((_neotrof >= 2.1) && (_neotrof <= 6.4))
                    {
                        neotrof.Text = "в нормата";
                    }

                    if (_neotrof < 2.1)
                    {
                        neotrof.Text = "ниско";
                    }

                    if (_neotrof > 6.4)
                    {
                        neotrof.Text = "високо";
                    }
                }

                if ((inr.Visible == true))
                {
                    double _inr = Double.Parse(inr.Text);

                    if ((_inr >= 1.2) && (_inr <= 1.6))
                    {
                        inr.Text = "в нормата";
                    }

                    if (_inr < 1.2)
                    {
                        inr.Text = "ниско";
                    }

                    if (_inr > 1.6)
                    {
                        inr.Text = "високо";
                    }
                }

                if ((mch.Visible == true))
                {
                    int _mch = Int32.Parse(mch.Text);

                    if ((_mch >= 27) && (_mch <= 33))
                    {
                        mch.Text = "в нормата";
                    }

                    if (_mch < 27)
                    {
                        mch.Text = "ниско";
                    }

                    if (_mch > 33)
                    {
                        mch.Text = "високо";
                    }
                }

                if ((cpkm.Visible == true))
                {
                    int _cpkm = Int32.Parse(cpkm.Text);

                    if ((_cpkm >= 0) && (_cpkm <= 25))
                    {
                        cpkm.Text = "в нормата";
                    }

                    if (_cpkm > 25)
                    {
                        cpkm.Text = "високо";
                    }
                }

                if ((mchc.Visible == true))
                {
                    int _mchc = Int32.Parse(mchc.Text);

                    if ((_mchc >= 300) && (_mchc <= 360))
                    {
                        mchc.Text = "в нормата";
                    }

                    if (_mchc < 300)
                    {
                        mchc.Text = "ниско";
                    }

                    if (_mchc > 360)
                    {
                        mchc.Text = "високо";
                    }
                }

                if ((rdw.Visible == true))
                {
                    double _rdw = Double.Parse(rdw.Text);

                    if ((_rdw >= 11.5) && (_rdw <= 14.5))
                    {
                        rdw.Text = "в нормата";
                    }

                    if (_rdw < 11.5)
                    {
                        rdw.Text = "ниско";
                    }

                    if (_rdw > 14.5)
                    {
                        rdw.Text = "високо";
                    }
                }

                if ((birarb.Visible == true))
                {
                    int _birarb = Int32.Parse(birarb.Text);

                    if ((_birarb >= 21) && (_birarb <= 25))
                    {
                        birarb.Text = "в нормата";
                    }

                    if (_birarb < 21)
                    {
                        birarb.Text = "ниско";
                    }

                    if (_birarb > 25)
                    {
                        birarb.Text = "високо";
                    }
                }

                if ((baziB.Visible == true))
                {
                    int _baziB = Int32.Parse(baziB.Text);

                    if ((_baziB >= 44) && (_baziB <= 48))
                    {
                        baziB.Text = "в нормата";
                    }

                    if (_baziB < 44)
                    {
                        baziB.Text = "ниско";
                    }

                    if (_baziB > 48)
                    {
                        baziB.Text = "високо";
                    }
                }

                if ((baziS.Visible == true))
                {
                    int _baziS = Int32.Parse(baziS.Text);

                    if ((_baziS >= 21) && (_baziS <= 25))
                    {
                        baziS.Text = "в нормата";
                    }

                    if (_baziS < 21)
                    {
                        baziS.Text = "ниско";
                    }

                    if (_baziS > 25)
                    {
                        baziS.Text = "високо";
                    }
                }

                if ((be.Visible == true))
                {
                    double _be = Double.Parse(be.Text);

                    if ((_be >= -2.4) && (_be <= 2.4))
                    {
                        be.Text = "в нормата";
                    }

                    if (_be < -2.4)
                    {
                        be.Text = "ниско";
                    }

                    if (_be > 2.4)
                    {
                        be.Text = "високо";
                    }
                }

                if ((bnp.Visible == true))
                {
                    int _bnp = Int32.Parse(bnp.Text);

                    if ((_bnp >= 0) && (_bnp <= 100))
                    {
                        bnp.Text = "в нормата";
                    }

                    if (_bnp > 100)
                    {
                        bnp.Text = "високо";
                    }
                }

                if ((npro.Visible == true))
                {
                    int _npro = Int32.Parse(npro.Text);

                    if ((_npro >= 0) && (_npro <= 900))
                    {
                        npro.Text = "в нормата";
                    }

                    if (_npro > 900)
                    {
                        npro.Text = "високо";
                    }
                }

                if ((cifra.Visible == true))
                {
                    double _cifra = Double.Parse(cifra.Text);

                    if ((_cifra >= 0) && (_cifra <= 3.3))
                    {
                        cifra.Text = "в нормата";
                    }

                    if (_cifra > 3.3)
                    {
                        cifra.Text = "високо";
                    }
                }

                if ((crp.Visible == true))
                {
                    int _crp = Int32.Parse(crp.Text);

                    if ((_crp >= 0) && (_crp <= 5))
                    {
                        crp.Text = "в нормата";
                    }

                    if (_crp > 5)
                    {
                        crp.Text = "високо";
                    }
                }

                if ((rbc.Visible == true))
                {
                    double _rbc = Double.Parse(rbc.Text);

                    if ((_rbc >= 4.3) && (_rbc <= 5.7))
                    {
                        rbc.Text = "в нормата";
                    }

                    if (_rbc < 4.3)
                    {
                        rbc.Text = "ниско";
                    }

                    if (_rbc > 5.7)
                    {
                        rbc.Text = "високо";
                    }
                }

                if ((bhh.Visible == true))
                {
                    int _bhh = Int32.Parse(bhh.Text);

                    if ((_bhh >= 0) && (_bhh <= 5))
                    {
                        bhh.Text = "в нормата";
                    }

                    if (_bhh > 5)
                    {
                        bhh.Text = "високо";
                    }
                }

                if ((po2.Visible == true))
                {
                    int _po2 = Int32.Parse(po2.Text);

                    if ((_po2 >= 98) && (_po2 <= 100))
                    {
                        po2.Text = "в нормата";
                    }

                    if (_po2 < 98)
                    {
                        po2.Text = "ниско";
                    }

                    if (_po2 > 100)
                    {
                        po2.Text = "високо";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Моля, въвеждайте само цифрови стойности в полетата !");

            }


        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void bloodExamin_Load(object sender, EventArgs e)
        {

        }

        private void alat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
