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
    public partial class ECG_diagnosis : Form
    {
        public ECG_diagnosis()
        {
            InitializeComponent();
        }    

        private void ecgChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ecgChoice.Text == "Остър  долно-латерален и преден миокарден инфаркт")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ACUTE INFERIOR AND ANTEROLATERAL MI.jpg");
                textBoxEcg.Text = "1.Q зъбци в долни (II,III и aVF),предни(I,aVL,V1-V2) и латерални(V5-V6) 2.Бифазни Т вълни във V2-V4 и инвертирани Т вълни във V5-V6,I, aVL-исхемия в неинфарктна зона";
            }

            else if (ecgChoice.Text == "Остър латерален миокарден инфаркт")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ACUTE LATERAL MI.jpg");
                textBoxEcg.Text = "ST елевация в латералните отвеждания-V5-V6,aVL,отрицателна Т вълна в същите отвеждания.";
            }

            else if (ecgChoice.Text == "Предсърдно мъждене , десен бедрен блок, ляв преден хемиблок")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/AFIBRILLATION,RBBB AND LAFB.jpg");
                textBoxEcg.Text = "1.предсърдно мъждене, липса на р вълни във всички отвеждания,различни R-R интервали-широки QRS комплекси.2.Широки двузъби QRS комплекси във V1-V2,с вторични реполяризационни промени (-) Т вълна в същите отвеждания,дълбоки S зъбци във V5-V6";
            }

            else if (ecgChoice.Text == "AV блок първа степен")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/AV I DEGREE BLOCK.jpg");
                textBoxEcg.Text = "1.Синусов ритъм ,честота от около 90/мин.2.Всички PR интервали по-продължителни от 0.20 сек и еднакви по продължителност,без да има отпадане на камерен комплекс.3.Нормални по продължителност камерни комплекси  сегменти и Т вълна.";
            }

            else if (ecgChoice.Text == "Нодален ритъм")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/AV JUNCTIONAL RHYTHM.jpg");
                textBoxEcg.Text = "1.Липса на p вълни ,честота околo 60/min-ритъм от АВ съединението.2.Нормални QRS комплекси и Т вълна";
            }

            else if (ecgChoice.Text == "AV блок първа степен с хипокалиемия")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/HYPERKALIEMIA AND AV block I degree.jpg");
                textBoxEcg.Text = "1.Синусов ритъм.2.Удължен PR интервал над 0.20сек.-черен кръг.3.Високи Т вълни във всички прекордиални отвеждания-черен кръг.";
            }

            else if (ecgChoice.Text == "Ляв заден хемиблок")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/LPFB.jpg");
                textBoxEcg.Text = "1.Синусов ритъм.2.Лява патологична ос –дълбоки S зъбци в II,III, aVF отвеждания.";
            }

            else if (ecgChoice.Text == "Синдром на удължен QT интервал")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/PROLONGED QT INTERVAL.jpg");
                textBoxEcg.Text = "1.Синусов ритъм. 2.Нормален PR интервал и електрическа ос.3. Удължен QT  интервал над 440мсек.";
            }

            else if (ecgChoice.Text == "Синусова брадикардия")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SB.jpg");
                textBoxEcg.Text = "1.	Синусов ритъм ,с честота 55/мин.2.	Нормален PR интервал и електрическа ос.3.	Нормални QRS комплекси.";

            }

            else if (ecgChoice.Text == "Синусова брадикардия, AV блок II степен, ляв бедрен блок")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SB, AV block second degree(mobitz II) and LBBB.jpg");
                textBoxEcg.Text = "1. Синусов ритъм с честота 65/ мин.-син кръг.2.Внезапно отпадане на един QRS комплекс без предхождаща промяна в PR интервала- АV блок II  степен (Мьобиц 2)-жълт кръг 3.Широк QRS комплекс и липса на Q зъбец  в левите отвеждания,дълбок S зъбец в предните отвеждания-черен кръг.";
            }

            else if (ecgChoice.Text == "Синусов ритъм")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SINUS RHYTHM.jpg");
                textBoxEcg.Text = "1.Синусов ритъм.2.Нормален PR интервал и електрическа ос.3.Нормални QRS комплекси ,нормални ST сегменти.";
            }

            else if (ecgChoice.Text == "Синусова тахикардия")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ST.jpg");
                textBoxEcg.Text = "1.Синусов ритъм,синусова тахикардия -честота 150/мин2.Иначе нормална ЕКГ.";
            }

            else if (ecgChoice.Text == "Камерна бигеминия")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/VENTRICULAR BIGEMINY.jpg");
                textBoxEcg.Text = "1.Синусов ритъм.2.Нормален PR интервал и електрическа ос.3.Преждевременни камерни импулси ,сдвоени с един нормален комплекс .";
            }

            else if (ecgChoice.Text == "Камерен пейсмейкър")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/VENTRICULAR PACEMAKER.jpg");
                textBoxEcg.Text = "1.Дисоциация между QRS комплексите и ST сегмента,негативни Т вълни.2.Камерни комплекси с морфология на десен бедрен блок.3. Пейсмейкърен спайк пред всеки камерен комплекс.";
            }

            else if (ecgChoice.Text == "Камерна тахикардия")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/VT.jpg");
                textBoxEcg.Text = "1.Ширококомплексен ритъм с честота около 1660/мин.2.Липсва асоциация с предсърдния ритъм-няма конкордантност между р вълните и камерните комплекси-> камерна тахикардия-червен кръг3.Диференциална диагноза с бедрен блок,аберантно проведена  надкамерна тахикардия!";
            }

            else if (ecgChoice.Text == "WPW")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/WPW.jpg");
                textBoxEcg.Text = "1.Синусов ритъм.2.Скъсен PR интервал под 0.12сек.-черен кръг.3.Широк QRS комплекс с начална полегата част –делта вълна-червен и жълт кръг.";
            }

            else if (ecgChoice.Text == "Ширококомплексни екстрасистоли")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/VENTRICULAR EXTRASYSTOLES.jpg");
                textBoxEcg.Text = "1.	Синусов ритъм.Нормален PR интервал и електрическа ос. Нормални QRS комплекси.Чести камерни екстрасистоли";
            }

            else if (ecgChoice.Text == "Стар долен миокарден инфаркт")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/OLD INFERIOIR MIOCARDIAL INFARCTION.jpg");
                textBoxEcg.Text = "1.Синусов ритъм.2.Q зъбци в I, III и aVF и отрицателни Т вълни-син и черен кръг 3.Високи Т вълни в V1-2отвеждане – исхемия";
            }

            else if (ecgChoice.Text == "AV блок III степен")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/AV BLOCK III DEGREE(COMPLETE).jpg");
                textBoxEcg.Text = "1. Сърдечна честота 45 /мин,предсърдна честота от около 70 удара /мин.2.Налични р вълни и QRSкомплекси, но няма връзка между тях  ,няма синхронизация между двата водача на ритъма(предсърдно-камерна дисоциация)-червен кръг.3.Лява патологична електрическа ос –дълбоки S зъбци в I, aVL отвеждания-син кръг";
            }

            else if (ecgChoice.Text == "Тежка лявокамерна хипертрофия")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SEVERE LEFT VENTRICULAR HYPERTROPHY.jpg");
                textBoxEcg.Text = "1.Синусов ритъм,честота:70/мин 2.Абнормно  висок R зъбец в левите отвеждания-черен кръг.3.Абнормно дълбок S зъбец в V1,V2-черен кръг.4.Сумата от R зъбеца V6 и S зъбеца в V1e  >40мм 5.R в aVL е над 13 мм 6.	R в aVL + S зъбеца в V3 е над 20 мм.7.	(-)Т вълна в левите отвеждания-червен кръг.";
            }

            else if (ecgChoice.Text == "Синусов ритъм с предсърдни екстрасистоли")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SINUS RHYTHM WITH ATRIAL EXTRASYSTOLES.jpg");
                textBoxEcg.Text = "1.Синусов ритъм.2.Нормален PR интервал и електрическа ос.3.Нормални QRS комплекси ,нормални ST сегменти.4.Предсърни екстрасистоли-теснокомплексни с широки и абнормни предхождащи ги р вълни , с компенсаторна пауза – червен кръг.";
            }

            else if (ecgChoice.Text == "Предсъдно трептене с 2:1 блок")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ATRIAL FLUTTER WITH 2 1 BLOCK.jpg");
                textBoxEcg.Text = "1.Честота около 150 удара в минута (заради блока-предсърдна честота 300/мин).2. Нормални QRS комплекси и ST сегмент.3.Блок 2:1 –най-добре видим в I,aVR,aVF.";
            }

            else if (ecgChoice.Text == "Синусова аритмия")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SINUS ARHYTHMY.jpg");
                textBoxEcg.Text = "1.Варираща с дишането синусова аритмия при иначе напълно здраво сърце на млад пациент.2.С променяща се честота на QRS комплексите ,но с ясно видими р вълни.";
            }

            else if (ecgChoice.Text == "Синусова тахикардия с неспецифични ST промени , говорещи за белодробна тромбемболия")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SINUS TACHICARDY,ST CHANGES,SUGESTING PE.jpg");
                textBoxEcg.Text = "1.Синусов ритъм,синусова тахикардия -честота 150/мин-черен кръг.2.Нормален PR интервал и електрическа ос.3.ST депресия в V1-4-червен кръг.4.	Бифазни или отрицателни Т вълни в прекордиалните отвеждания-син кръг.5.	Констелацията съответства на БТЕ.";
            }

            else if (ecgChoice.Text == "AV блок I степен с остър Non-Q миокарден инфаркт")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/AV BLOCK I DEGREE AND NON-Q AMI.jpg");
                textBoxEcg.Text = "1.PR интервал ,удължен над 0.20сек.,всяка р вълна се последва от QRS комплекс ,но със закъснение- AV  блок I степен-червен кръг.2.Негативна Т вълна в V1-V3 отвеждане,нормални QRS комплекси,ST сегмент-син кръг.";
            }

            else if (ecgChoice.Text == "Миокардна исхемия с ST депресия")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ST CHANGES DUE TO MIOCARDIAL ISCHAEMIA.jpg");
                textBoxEcg.Text = "1. Синусов ритъм.2. Нормален PR интервал и електрическа ос.3. ST депресия –I,II,aVL- хоризонтална , над 2 мм";
            }

            else if (ecgChoice.Text == "Декстрокардия")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/DEXTROCARDIA.jpg");
                textBoxEcg.Text = "1.Синусов ритъм.2.Инвертирана р вълна в първо отвеждане-червен кръг.3.Дясна патологична ос –зелен кръг.4.Липсва прогресия на камерните комплекси в прекордиалните отвеждания-жълт кръг.5. (+) камерен комплекс в аVR .";
            }

            else if (ecgChoice.Text == "Стар миокарден инфаркт с камерна аневризма")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/OLD MI WITH VENTRICULAR ANEURISM.jpg");
                textBoxEcg.Text = "1.Синусов ритъм,синусова тахикардия с  честота над 280/мин-черен кръг2.Q зъбец в I, aVL ,V2-5 отвеждане ,ST елевация в същите отвеждания-син и червен кръг застинал образ на миокарден инфаркт при образуване на камерна аневризма";
            }

            else if (ecgChoice.Text == "Стар миокарден инфаркт с R върху T камерна екстрасистола, водеща до камерно трептене")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/OLD MI, R ON T VENTRICULAR TACHICARDY CAUSING VENTRICULAR FIBRILLATION.jpg");
                textBoxEcg.Text = "1.Синусов ритъм с камерни екстрасистоли 2.Третата екстрасистола  се появява на върха на Т вълната и ритъмът преминава в камерно мъждене- червен кръг.3. По време на синусовия ритъм има Q зъбец в III отвеждане , ST елевация в II,III отвеждане и ST депресия и Т вълнова инверсия в I отвеждане-черен и син кръг.";
            }

            else if (ecgChoice.Text == "Акцелериран идионодален ритъм")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ACCELERATED IDIONODAL RHYTHM.jpg");
                textBoxEcg.Text = "1.Тесни QRS комплекси с честота 35 удара в минута-нодален ритъм.2.PRинтервал –варира при всеки цикъл-черен кръг-идионодален ритъм,ритъмът се заражда в предсърдието,на място, различно от синусовия възел , или в АV съединението .3.Нормални QRS комплекс и STсегмент.";
            }

            else if (ecgChoice.Text == "Плоска Т вълна, с поява на U вълна, хипокалиемия, вероятен микседем")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/FLAT T WAVE, U WAVE DUE TO HYPOKALIEMIA.jpg");
                textBoxEcg.Text = "1.Синусов ритъм.2.Нормални камерни комплекси и ST сегмент 3.Плоска Т вълна –черен кръг Поява на U вълна –червен кръг";
            }            

            else if (ecgChoice.Text == "Ширококомплексна тахикардия, дължаща се на синдром на WPW")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/BROAD COMPLEX TACHYCARDIA DUE TO WPW SYNDROME.jpg");
                textBoxEcg.Text = "1.	Ширококомплексни тахикардия от около 250/мин,QRS комплекси-продължителност над 180мсек.2.Липсва р вълна.3.Дясна патологична ос-червен кръг.4.Положителни QRS комплекси в V1и отрицателни в V6  липса на конкордантност.5.Камерни комплекси с форма на десен бедрен блок,като първия зъбец е по-висок от втория-син кръг.";
            }            

            else if (ecgChoice.Text == "Деснокамерна хипертрофия")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/RIGHT VENTRICULAR HYPERTROPHY.jpg");
                textBoxEcg.Text = "1.Синусов ритъм.2.Заострени р вълни ,най-добре видими в II отвеждане-ДП  обременяване- черен кръг 3.Изразен R зъбец в V1-2,с вторични реполяризационни промени,патологичен Q зъбец и липса на S зъбец –ДК обременяване-червен кръг. 4. Голям S зъбец в левите отвеждания-V5,V6-син кръг.";
            }

            else if (ecgChoice.Text == "Синдром на болния синусов възел")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SICK SINUS SINDROME AND JUNCTIONAL ESCAPE RHYTHM.jpg");
                textBoxEcg.Text = "1.Вариабилна честота на QRS комплексите 2. Няма р вълни.3.”Тихо предсърдие “ с вариабилен нодален спасителен ритъм.";
            }

            else if (ecgChoice.Text == "Предсърдно трептене с AV блок 4:1")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ATRIAL FLUTTER WITH 4  1 BLOCK.jpg");
                textBoxEcg.Text = "1.Честота  около 75/мин (предсърдна честота 300/ мин).2.F вълни-черен кръг.3.Няма р вълни.4.Няма подлежащо сърдечно заболяване";
            }

            else if (ecgChoice.Text == "ST елевация във всички отвеждания , дължаща се на перикардит")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ST ELEVATION DUE TO PERICARDITIS.jpg");
                textBoxEcg.Text = "1.Синусов ритъм.2.Нормален PR интервал и електрическа ос.3.Нормални QRS комплекси.4 ST елевация във всички отвеждания ,с изключение на aVR";
            }

            else if (ecgChoice.Text == "LGL синдром")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/LGL SYNDROME.jpg");
                textBoxEcg.Text = "1.Синусов ритъм,честота 65 /мин.2.Скъсен PR интервал под 0.12сек. ,но без поява на делта вълна.";
            }

            else if (ecgChoice.Text == "T вълнова инверсия, дължаща се на субарахноидален кръвоизлив")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/T WAVE INVERSION DUE TO SUBARACHNOID HAEMORRHAGE.jpg");
                textBoxEcg.Text = "1.Синусов ритъм, честота 80/мин.2.Нормален PR интервал и електрическа ос.3.ST депресия в II отвеждане .4.Инверсия на Т вълната в III,aVF,V4-6.5.	Може да се направи диференциална диагноза с Non-Q ОМИ ,зависи от клиничната картина!";
            }

            else if (ecgChoice.Text == "Перикарден излив с бифазни и отрицателни Т вълни")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/PERICARDIAL EFFUSION -SMALL T WAVES.jpg");
                textBoxEcg.Text = "1.Синусов ритъм ,честота 100 / мин.2.Малък волтаж в прекордиалните отвеждания на QRS комплексите-червен кръг.3.Отрицателна Т  вълна вI,II, III, aVF,V4-6 –черен кръг.";
            }

            else if (ecgChoice.Text == "Предсърдно мъждене с WPW синдром")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ATRIAL FIBRILATION AND WPW.jpg");
                textBoxEcg.Text = "1. Няма р вълни ,различни RR интервали-червен кръг 2.Делта вълна в I,aVL,V4-V5- син кръг. 3. Животозастрашаващо състояние, не се дават медикаменти,блокиращи проводимостта през АВ съединението,може да дегенерира  в камерно трептене";
            }

            else if (ecgChoice.Text == "Prinzmetal ангина")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/PRINZMETAL VARIANT ANGINA.jpg");
                textBoxEcg.Text = "1.Артефакти в V1,V3.2. Синусов ритъм.3.Нормален PR интервал и електрическа ос.4.Широки QRS комплекси -160мсек-червен кръг.5.ST елевация  в II,III, V5-6,aVF  и ST депресия в I,aVR ,aVL,V1-3 отвеждания.6. Нормална Т вълна.";
            }

            else if (ecgChoice.Text == "Brugada  синдром")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/BRUGADA SYNDROME.jpg");
                textBoxEcg.Text = "1.Синусов ритъм-честота 70/мин.2.Нормални PR интервали и QRS комплекси.3.QRS комплекси във V1-2 с rSr форма. 4.ST сегмент-елевация и down –sloping вид в V1-2.5.(-) Т вълна в същите отвеждания.";
            }
            else if (ecgChoice.Text == "AV блок 2:1 , десен бедрен блок, ляв преден хемиблок")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/AV BLOCK 2  1,LAHB,RBBB(TRIFASCICULAR BLOCK).jpg");
                textBoxEcg.Text = "1.Не всяка предсърдна р вълна  се последва от QRS комплекс,всяка втора се провежда през АВ възела –син кръг.2.Широк QRS комплекс >0.12,лява електрическа ос,нормална Т вълна-червен кръг.3.rR’ форма на QRS комплексите в V1,с вторични реполяризационни промени-отрицателна Т вълна,липсва Q зъбец в I,aVL ,V6 -черен кръг.";
            }
        }

        private void ECG_diagnosis_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxEcg.Text == "1.Q зъбци в долни (II,III и aVF),предни(I,aVL,V1-V2) и латерални(V5-V6) 2.Бифазни Т вълни във V2-V4 и инвертирани Т вълни във V5-V6,I, aVL-исхемия в неинфарктна зона")
            {
                pictureBoxEcg.Image= new Bitmap(@"../../EKG_images/ACUTE INFERIOR AND ANTEROLATERAL MI-kryg4e.jpg");
            }

            else if(textBoxEcg.Text== "ST елевация в латералните отвеждания-V5-V6,aVL,отрицателна Т вълна в същите отвеждания.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ACUTE LATERAL MI- kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.предсърдно мъждене, липса на р вълни във всички отвеждания,различни R-R интервали-широки QRS комплекси.2.Широки двузъби QRS комплекси във V1-V2,с вторични реполяризационни промени (-) Т вълна в същите отвеждания,дълбоки S зъбци във V5-V6")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/AFIBRILLATION,RBBB AND LAFB-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм ,честота от около 90/мин.2.Всички PR интервали по-продължителни от 0.20 сек и еднакви по продължителност,без да има отпадане на камерен комплекс.3.Нормални по продължителност камерни комплекси  сегменти и Т вълна.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/AV I DEGREE BLOCK-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Липса на p вълни ,честота околo 60/min-ритъм от АВ съединението.2.Нормални QRS комплекси и Т вълна")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/AV JUNCTIONAL RHYTHM-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм.2.Удължен PR интервал над 0.20сек.-черен кръг.3.Високи Т вълни във всички прекордиални отвеждания-черен кръг.")          
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/HYPERKALIEMIA AND AV block I degree-kryg4e.jpg");
            }          

            else if (textBoxEcg.Text == "1.Синусов ритъм.2.Лява патологична ос –дълбоки S зъбци в II,III, aVF отвеждания.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/LPFB-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм. 2.Нормален PR интервал и електрическа ос.3. Удължен QT  интервал над 440мсек.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/PROLONGED QT INTERVAL-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.	Синусов ритъм ,с честота 55/мин.2.	Нормален PR интервал и електрическа ос.3.	Нормални QRS комплекси.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SB-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1. Синусов ритъм с честота 65/ мин.-син кръг.2.Внезапно отпадане на един QRS комплекс без предхождаща промяна в PR интервала- АV блок II  степен (Мьобиц 2)-жълт кръг 3.Широк QRS комплекс и липса на Q зъбец  в левите отвеждания,дълбок S зъбец в предните отвеждания-черен кръг.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SB, AV block second degree(mobitz II) and LBBB-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм.2.Нормален PR интервал и електрическа ос.3.Нормални QRS комплекси ,нормални ST сегменти.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SINUS RHYTHM-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм,синусова тахикардия -честота 150/мин2.Иначе нормална ЕКГ.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ST-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм.2.Нормален PR интервал и електрическа ос.3.Преждевременни камерни импулси ,сдвоени с един нормален комплекс .")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/VENTRICULAR BIGEMINY-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Дисоциация между QRS комплексите и ST сегмента,негативни Т вълни.2.Камерни комплекси с морфология на десен бедрен блок.3. Пейсмейкърен спайк пред всеки камерен комплекс.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/VENTRICULAR PACEMAKER-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Ширококомплексен ритъм с честота около 1660/мин.2.Липсва асоциация с предсърдния ритъм-няма конкордантност между р вълните и камерните комплекси-> камерна тахикардия-червен кръг3.Диференциална диагноза с бедрен блок,аберантно проведена  надкамерна тахикардия!")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/VT-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм.2.Скъсен PR интервал под 0.12сек.-черен кръг.3.Широк QRS комплекс с начална полегата част –делта вълна-червен и жълт кръг.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/WPW-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.	Синусов ритъм.Нормален PR интервал и електрическа ос. Нормални QRS комплекси.Чести камерни екстрасистоли")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/VENTRICULAR EXTRASYSTOLES-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм.2.Q зъбци в I, III и aVF и отрицателни Т вълни-син и черен кръг 3.Високи Т вълни в V1-2отвеждане – исхемия")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/OLD INFERIOIR MIOCARDIAL INFARCTION-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1. Сърдечна честота 45 /мин,предсърдна честота от около 70 удара /мин.2.Налични р вълни и QRSкомплекси, но няма връзка между тях  ,няма синхронизация между двата водача на ритъма(предсърдно-камерна дисоциация)-червен кръг.3.Лява патологична електрическа ос –дълбоки S зъбци в I, aVL отвеждания-син кръг")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/AV BLOCK III DEGREE(COMPLETE)-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм,честота:70/мин 2.Абнормно  висок R зъбец в левите отвеждания-черен кръг.3.Абнормно дълбок S зъбец в V1,V2-черен кръг.4.Сумата от R зъбеца V6 и S зъбеца в V1e  >40мм 5.R в aVL е над 13 мм 6.	R в aVL + S зъбеца в V3 е над 20 мм.7.	(-)Т вълна в левите отвеждания-червен кръг.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SEVERE LEFT VENTRICULAR HYPERTROPHY-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм.2.Нормален PR интервал и електрическа ос.3.Нормални QRS комплекси ,нормални ST сегменти.4.Предсърни екстрасистоли-теснокомплексни с широки и абнормни предхождащи ги р вълни , с компенсаторна пауза – червен кръг.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SINUS RHYTHM WITH ATRIAL EXTRASYSTOLES-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Честота около 150 удара в минута (заради блока-предсърдна честота 300/мин).2. Нормални QRS комплекси и ST сегмент.3.Блок 2:1 –най-добре видим в I,aVR,aVF.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ATRIAL FLUTTER WITH 2 1 BLOCK-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Варираща с дишането синусова аритмия при иначе напълно здраво сърце на млад пациент.2.С променяща се честота на QRS комплексите ,но с ясно видими р вълни.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SINUS ARHYTHMY-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм,синусова тахикардия -честота 150/мин-черен кръг.2.Нормален PR интервал и електрическа ос.3.ST депресия в V1-4-червен кръг.4.	Бифазни или отрицателни Т вълни в прекордиалните отвеждания-син кръг.5.	Констелацията съответства на БТЕ.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SINUS TACHICARDY,ST CHANGES,SUGESTING PE-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.PR интервал ,удължен над 0.20сек.,всяка р вълна се последва от QRS комплекс ,но със закъснение- AV  блок I степен-червен кръг.2.Негативна Т вълна в V1-V3 отвеждане,нормални QRS комплекси,ST сегмент-син кръг.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/AV BLOCK I DEGREE AND NON-Q AMI-kryg4e.jpg");
            }


            else if (textBoxEcg.Text == "1. Синусов ритъм.2. Нормален PR интервал и електрическа ос.3. ST депресия –I,II,aVL- хоризонтална , над 2 мм")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ST CHANGES DUE TO MIOCARDIAL ISCHAEMIA-kryg4e.jpg");
            }


            else if (textBoxEcg.Text == "1.Синусов ритъм.2.Инвертирана р вълна в първо отвеждане-червен кръг.3.Дясна патологична ос –зелен кръг.4.Липсва прогресия на камерните комплекси в прекордиалните отвеждания-жълт кръг.5. (+) камерен комплекс в аVR .")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/DEXTROCARDIA-kryg4e.jpg");
            }


            else if (textBoxEcg.Text == "1.Синусов ритъм,синусова тахикардия с  честота над 280/мин-черен кръг2.Q зъбец в I, aVL ,V2-5 отвеждане ,ST елевация в същите отвеждания-син и червен кръг застинал образ на миокарден инфаркт при образуване на камерна аневризма")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/OLD MI WITH VENTRICULAR ANEURISM-kryg4e.jpg");
            }


            else if (textBoxEcg.Text == "1.Синусов ритъм с камерни екстрасистоли 2.Третата екстрасистола  се появява на върха на Т вълната и ритъмът преминава в камерно мъждене- червен кръг.3. По време на синусовия ритъм има Q зъбец в III отвеждане , ST елевация в II,III отвеждане и ST депресия и Т вълнова инверсия в I отвеждане-черен и син кръг.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/OLD MI, R ON T VENTRICULAR TACHICARDY CAUSING VENTRICULAR FIBRILLATION-kryg4e.jpg");
            }


            else if (textBoxEcg.Text == "1.Тесни QRS комплекси с честота 35 удара в минута-нодален ритъм.2.PRинтервал –варира при всеки цикъл-черен кръг-идионодален ритъм,ритъмът се заражда в предсърдието,на място, различно от синусовия възел , или в АV съединението .3.Нормални QRS комплекс и STсегмент.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ACCELERATED IDIONODAL RHYTHM kryg4e.jpg");
            }


            else if (textBoxEcg.Text == "1.Синусов ритъм.2.Нормални камерни комплекси и ST сегмент 3.Плоска Т вълна –черен кръг Поява на U вълна –червен кръг")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/FLAT T WAVE, U WAVE DUE TO HYPOKALIEMIA-kryg4e.jpg");
            }


            else if (textBoxEcg.Text == "1.	Ширококомплексни тахикардия от около 250/мин,QRS комплекси-продължителност над 180мсек.2.Липсва р вълна.3.Дясна патологична ос-червен кръг.4.Положителни QRS комплекси в V1и отрицателни в V6  липса на конкордантност.5.Камерни комплекси с форма на десен бедрен блок,като първия зъбец е по-висок от втория-син кръг.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/BROAD COMPLEX TACHYCARDIA DUE TO WPW SYNDROME-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм.2.Заострени р вълни ,най-добре видими в II отвеждане-ДП  обременяване- черен кръг 3.Изразен R зъбец в V1-2,с вторични реполяризационни промени,патологичен Q зъбец и липса на S зъбец –ДК обременяване-червен кръг. 4. Голям S зъбец в левите отвеждания-V5,V6-син кръг.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/RIGHT VENTRICULAR HYPERTROPHY-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Вариабилна честота на QRS комплексите 2. Няма р вълни.3.”Тихо предсърдие “ с вариабилен нодален спасителен ритъм.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/SICK SINUS SINDROME AND JUNCTIONAL ESCAPE RHYTHM-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Честота  около 75/мин (предсърдна честота 300/ мин).2.F вълни-черен кръг.3.Няма р вълни.4.Няма подлежащо сърдечно заболяване")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ATRIAL FLUTTER WITH 4  1 BLOCK-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм.2.Нормален PR интервал и електрическа ос.3.Нормални QRS комплекси.4 ST елевация във всички отвеждания ,с изключение на aVR")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ST ELEVATION DUE TO PERICARDITIS-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм,честота 65 /мин.2.Скъсен PR интервал под 0.12сек. ,но без поява на делта вълна.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/LGL SYNDROME-KRYG4E.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм, честота 80/мин.2.Нормален PR интервал и електрическа ос.3.ST депресия в II отвеждане .4.Инверсия на Т вълната в III,aVF,V4-6.5.	Може да се направи диференциална диагноза с Non-Q ОМИ ,зависи от клиничната картина!")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/T WAVE INVERSION DUE TO SUBARACHNOID HAEMORRHAGE-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм ,честота 100 / мин.2.Малък волтаж в прекордиалните отвеждания на QRS комплексите-червен кръг.3.Отрицателна Т  вълна вI,II, III, aVF,V4-6 –черен кръг.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/PERICARDIAL EFFUSION -SMALL T WAVES-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1. Няма р вълни ,различни RR интервали-червен кръг 2.Делта вълна в I,aVL,V4-V5- син кръг. 3. Животозастрашаващо състояние, не се дават медикаменти,блокиращи проводимостта през АВ съединението,може да дегенерира  в камерно трептене")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/ATRIAL FIBRILATION AND WPW-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Артефакти в V1,V3.2. Синусов ритъм.3.Нормален PR интервал и електрическа ос.4.Широки QRS комплекси -160мсек-червен кръг.5.ST елевация  в II,III, V5-6,aVF  и ST депресия в I,aVR ,aVL,V1-3 отвеждания.6. Нормална Т вълна.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/PRINZMETAL VARIANT ANGINA-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Синусов ритъм-честота 70/мин.2.Нормални PR интервали и QRS комплекси.3.QRS комплекси във V1-2 с rSr форма. 4.ST сегмент-елевация и down –sloping вид в V1-2.5.(-) Т вълна в същите отвеждания.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/BRUGADA SYNDROME-kryg4e.jpg");
            }

            else if (textBoxEcg.Text == "1.Не всяка предсърдна р вълна  се последва от QRS комплекс,всяка втора се провежда през АВ възела –син кръг.2.Широк QRS комплекс >0.12,лява електрическа ос,нормална Т вълна-червен кръг.3.rR’ форма на QRS комплексите в V1,с вторични реполяризационни промени-отрицателна Т вълна,липсва Q зъбец в I,aVL ,V6 -черен кръг.")
            {
                pictureBoxEcg.Image = new Bitmap(@"../../EKG_images/AV BLOCK 2  1,LAHB,RBBB(TRIFASCICULAR BLOCK)-kryg4e.jpg");
            }

            
        }

        
        

       
    }
}
