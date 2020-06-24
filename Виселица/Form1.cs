using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Виселица
{
    public partial class Form1 : Form
    {
          

        //Слова
        string[] animals = { "собака", "кошка", "голубь", "тигр", "аллигатор", "рысь", "ворона", "заяц", "свинья", "кролик", "жираф ", "слон", "ёж", "кабан", "медведь", "кит", "дельфин", "кенгуру", "скунс", "индюк", "лось", "петух", "лошадь", "гусь", "тюлень", "тушканчик", "гепард", "леопард", "пантера", "лев", "волк", "выдра", "аист", "улитка", "слизняк", "ящерица", "змея", "паук", "верблюд", "хорёк", "ласка", "коала", "панда", "морж", "акула", "корова", "овца", "капибара", "коза", "медоед", "лемур", "обезьяна " };
        string[] countries = { "бельгия", "сша", "россия", "швеция", "норвегия", "швейцария", "африка", "индия", "новороссия", "украина", "китай", "корея", "германия", "япония", "татарстан", "мексика", "австрия", "албания", "алжир", "испания", "ватикан", "венгрия", "дания", "израиль", "зимбабве", "египет", "иран", "ирак", "индонезия", "италия", "колумбия", "конго", "куба", "мадагаскар", "нигерия", "нидерланды", "оаэ", "оман", "британия", "германия", "англия" };
        string[] plants = { "одуванчик", "крапива", "венерина", "мухоловка", "орхидея", "ромашка", "абелия", "абрикос", "багряник", "базилик", "бамбук", "бамия", "барбарис", "валериана", "василёк", "роза", "редис", "репей", "нарцисс", "гвоздика", "тюльпан", "мак", "колокольчик", "гербера", "ирис", "астра", "гибискус", "плющ", "фикус", "лавр", "алоэ", "кактус", "кислица", "герань", "лимон", "мирт", "фиалка", "кливия", "бальзамин", "паслён", "антуриум", "гортензия", "бегония", "эвкалипт", "хлорофиптун", "лилия", "подсолнух", "хризантема", "драцена", "ракитник", "агава", "волжанка", "дельфиниум" };
        string[] hobby = { "баскетбол", "волейбол", "анимация", "футбол", "гребля", "лакросс", "бег", "регби", "поход", "гандбол", "охота", "тхэквандо", "бокс", "каратэ", "поло", "мотоспорт", "паркур", "пчеловодство", "овощеводство", "стрельба", "теннис", "автогонки", "альпинизм", "борьба", "скейтбординг", "плавание", "ракетбол", "бейсбол", "фехтование", "плавание", "боулинг", "шахматы", "танцы", "дзюдо", "хоккей", "троеборье", "рисование", "музыка" };
        string[] science = { "математика", "информатика", "логика", "антропология", "физика", "статистика", "история", "право", "социология", "политология", "культурология", "экономика", "лингвистика", "психология", "литературоведение", "искусствоведение", "педагогика", "этика", "эстетика", "журналистика", "фрилогия", "астрономия", "биология", "химия", "ветеринария", "география", "геология", "медицина", "метеорология", "океанология", "архитектура", "механика", "строительство", "энергетика", "космонавтика", "кораблестроение", "биотехнология" };
        string[] all = { "собака", "кошка", "голубь", "тигр", "аллигатор", "рысь", "ворона", "заяц", "свинья", "кролик", "жираф ", "слон", "ёж", "кабан", "медведь", "кит", "дельфин", "кенгуру", "скунс", "индюк", "лось", "петух", "лошадь", "гусь", "тюлень", "тушканчик", "гепард", "леопард", "пантера", "лев", "волк", "выдра", "аист", "улитка", "слизняк", "ящерица", "змея", "паук", "верблюд", "хорёк", "ласка", "коала", "панда", "морж", "акула", "корова", "овца", "капибара", "коза", "медоед", "лемур", "обезьяна ", "математика", "информатика", "логика", "антропология", "физика", "статистика", "история", "право", "социология", "политология", "культурология", "экономика", "лингвистика", "психология", "литературоведение", "искусствоведение", "педагогика", "этика", "эстетика", "журналистика", "фрилогия", "астрономия", "биология", "химия", "ветеринария", "география", "геология", "медицина", "метеорология", "океанология", "архитектура", "механика", "строительство", "энергетика", "космонавтика", "кораблестроение", "биотехнология", "одуванчик", "крапива", "венерина", "мухоловка", "орхидея", "ромашка", "абелия", "абрикос", "багряник", "базилик", "бамбук", "бамия", "барбарис", "валериана", "василёк", "роза", "редис", "репей", "нарцисс", "гвоздика", "тюльпан", "мак", "колокольчик", "гербера", "ирис", "астра", "гибискус", "плющ", "фикус", "лавр", "алоэ", "кактус", "кислица", "герань", "лимон", "мирт", "фиалка", "кливия", "бальзамин", "паслён", "антуриум", "гортензия", "бегония", "эвкалипт", "хлорофиптун", "лилия", "подсолнух", "хризантема", "драцена", "ракитник", "агава", "волжанка", "дельфиниум", "бельгия", "сша", "россия", "швеция", "норвегия", "швейцария", "африка", "индия", "новороссия", "украина", "китай", "корея", "германия", "япония", "татарстан", "мексика", "австрия", "албания", "алжир", "испания", "ватикан", "венгрия", "дания", "израиль", "зимбабве", "египет", "иран", "ирак", "индонезия", "италия", "колумбия", "конго", "куба", "мадагаскар", "нигерия", "нидерланды", "оаэ", "оман", "британия", "германия", "англия", "баскетбол", "волейбол", "анимация", "футбол", "гребля", "лакросс", "бег", "регби", "поход", "гандбол", "охота", "тхэквандо", "бокс", "каратэ", "поло", "мотоспорт", "паркур", "пчеловодство", "овощеводство", "стрельба", "теннис", "автогонки", "альпинизм", "борьба", "скейтбординг", "плавание", "ракетбол", "бейсбол", "фехтование", "плавание", "боулинг", "шахматы", "танцы", "дзюдо", "хоккей", "троеборье", "рисование", "музыка" };

        //переменные
        Random rn = new Random();
        int i, wrongGuesses;
        char guess;
        string word, displayString;
        char[] disp, wordChar, oldDisp;
        List<char> charList = new List<char>();
        Object obj = new Object();
        EventArgs ea = new EventArgs();

        public Form1()
        {
            InitializeComponent();
            DisableButtons();
            this.KeyPreview = true;
            Все.Checked = true;
            Показатьответ.Visible = false;
        }

        //изначально все кнопки с буквами деактивированы, чтобы не повторять строки кода написал в метод
        public void DisableButtons() 
        {
            this.KeyPreview = false;
            А.Enabled = false;
            Б.Enabled = false;
            В.Enabled = false;
            Г.Enabled = false;
            Д.Enabled = false;
            Е.Enabled = false;
            Ё.Enabled = false;
            Ж.Enabled = false;
            З.Enabled = false;
            И.Enabled = false;
            Й.Enabled = false;
            К.Enabled = false;
            Л.Enabled = false;
            М.Enabled = false;
            Н.Enabled = false;
            О.Enabled = false;
            П.Enabled = false;
            Р.Enabled = false;
            С.Enabled = false;
            Т.Enabled = false;
            У.Enabled = false;
            Ф.Enabled = false;
            Х.Enabled = false;
            Ц.Enabled = false;
            Ч.Enabled = false;
            Ш.Enabled = false;
            Щ.Enabled = false;
            Ъ.Enabled = false;
            Ы.Enabled = false;
            Ь.Enabled = false;
            Э.Enabled = false;
            Ю.Enabled = false;
            Я.Enabled = false;
        }
        // активация кнопок при нажатии новая игра и выбор группы слов
        public void Новаяигра_Click(object sender, EventArgs e)
        {
            
            if (Животные.Checked)
            {
                word = animals[rn.Next(animals.Length)];
            }
            else if (Растения.Checked)
            {
                word = plants[rn.Next(plants.Length)];
            }
            else if (Наука.Checked)
            {
                word = science[rn.Next(science.Length)];
            }
            else if (Хобби.Checked)
            {
                word = hobby[rn.Next(hobby.Length)];
            }
            else if (Страны.Checked)
            {
                word = countries[rn.Next(countries.Length)];
            }
            else
            {
                word = all[rn.Next(all.Length)];
            }
            
            charList.Clear();
            wrongGuesses = 0;
            UpdatePic(0);
            Показатьответ.Visible = false;
           
            Form1 form1 = this;
            form1.KeyPreview = true;
            А.Enabled = true;
            Б.Enabled = true;
            В.Enabled = true;
            Г.Enabled = true;
            Д.Enabled = true;
            Е.Enabled = true;
            Ё.Enabled = true;
            Ж.Enabled = true;
            З.Enabled = true;
            И.Enabled = true;
            Й.Enabled = true;
            К.Enabled = true;
            Л.Enabled = true;
            М.Enabled = true;
            Н.Enabled = true;
            О.Enabled = true;
            П.Enabled = true;
            Р.Enabled = true;
            С.Enabled = true;
            Т.Enabled = true;
            У.Enabled = true;
            Ф.Enabled = true;
            Х.Enabled = true;
            Ц.Enabled = true;
            Ч.Enabled = true;
            Ш.Enabled = true;
            Щ.Enabled = true;
            Ъ.Enabled = true;
            Ы.Enabled = true;
            Ь.Enabled = true;
            Э.Enabled = true;
            Ю.Enabled = true;
            Я.Enabled = true;

            // чтобы изначально слово не было видно блок кода, который заменяет буквы на чёрты
            int dubs = word.Length * 2;
            disp = new char[(word.Length * 2)];
            oldDisp = new char[(word.Length * 2)];

            for (i = 0; i < (word.Length * 2); i += 2)
            {

                disp[i] = '_';
                disp[i + 1] = ' ';
                oldDisp[i] = '_';
                oldDisp[i + 1] = ' ';
            }

    
            wordChar = new char[(word.Length * 2)];
            for (i = 0; i < word.Length; i++)
            {
                wordChar[i] = word[i];
            }

            for (i = 0; i < wordChar.Length; i++)
            {
                charList.Add(wordChar[i]);
            }

  
            for (i = 1; i < dubs; i += 2)
            {
                charList.Insert(i, ' ');
            }
            label1.Text = "";
            displayString = "";
            
            for (i = 0; i < disp.Length; i++)
            {
                displayString = displayString + char.ToString(disp[i]);
            }

            label1.Text = displayString;
        }
        //блок кода, отвечающий за проверку буквы в слове при проверке через каждые две буквы
        public void CheckLetter(char g)
        {
            for (i = 0; i < disp.Length;)
            {
                if (g == charList[i])
                {
                    disp[i] = g;
                }
                i += 2;
            }


            if (new string(oldDisp) == new string(disp))
            {
                wrongGuesses++;
            }

            for (i = 0; i < disp.Length; i++)
            {
                oldDisp[i] = disp[i];
            }

            UpdatePic(wrongGuesses);

            displayString = "";
            for (i = 0; i < disp.Length; i++)
            {
                displayString = displayString + char.ToString(disp[i]);
            }

            label1.Text = displayString;

            if (!displayString.Contains("_"))
            {
                pic.Image = Виселица.Properties.Resources._10;
                DisableButtons();
            }
        }

        // обновление картинки при нажатии неверной клавиши
        public void UpdatePic(int wg)
        {
            switch (wg)
            {
                case 0:
                    pic.Image = Виселица.Properties.Resources._0;
                    break;
                case 1:
                    pic.Image = Виселица.Properties.Resources._1;
                    break;
                case 2:
                    pic.Image = Виселица.Properties.Resources._2;
                    break;
                case 3:
                    pic.Image = Виселица.Properties.Resources._3;
                    break;
                case 4:
                    pic.Image = Виселица.Properties.Resources._4;
                    break;
                case 5:
                    pic.Image = Виселица.Properties.Resources._5;
                    break;
                case 6:
                    pic.Image = Виселица.Properties.Resources._6;
                    break;
                case 7:
                    pic.Image = Виселица.Properties.Resources._7;
                    break;
                case 8:
                    pic.Image = Виселица.Properties.Resources._8;
                    break;
                default: 
                    pic.Image = Виселица.Properties.Resources._9;
                    Lost();
                    break;
            }
        }
        //после пройгрыша активируется кнопка показать ответ, а остальные неактивные
        public void Lost()
        {
            DisableButtons();
            Показатьответ.Visible = true;
        }
        //блок кода, отвечающий за нажатие кнопки, после чего идёт проверки той буквы в слове
        private void А_Click(object sender, EventArgs e)
        {
            guess = 'а';
            CheckLetter(guess);
            А.Enabled = false;
        }

        private void Б_Click(object sender, EventArgs e)
        {
            guess = 'б';
            CheckLetter(guess);
            Б.Enabled = false;
        }

        private void В_Click(object sender, EventArgs e)
        {
            guess = 'в';
            CheckLetter(guess);
            В.Enabled = false;
        }

        private void Г_Click(object sender, EventArgs e)
        {
            guess = 'г';
            CheckLetter(guess);
            Г.Enabled = false;
        }

        private void Д_Click(object sender, EventArgs e)
        {
            guess = 'д';
            CheckLetter(guess);
            Д.Enabled = false;
        }

        private void Е_Click(object sender, EventArgs e)
        {
            guess = 'е';
            CheckLetter(guess);
            Е.Enabled = false;
        }

        private void Ё_Click(object sender, EventArgs e)
        {
            guess = 'ё';
            CheckLetter(guess);
            Ё.Enabled = false;
        }

        private void Ж_Click(object sender, EventArgs e)
        {
            guess = 'ж';
            CheckLetter(guess);
            Ж.Enabled = false;
        }

        private void З_Click(object sender, EventArgs e)
        {
            guess = 'з';
            CheckLetter(guess);
            З.Enabled = false;
        }

        private void И_Click(object sender, EventArgs e)
        {
            guess = 'и';
            CheckLetter(guess);
            И.Enabled = false;
        }

        private void Й_Click(object sender, EventArgs e)
        {
            guess = 'й';
            CheckLetter(guess);
            Й.Enabled = false;
        }

        private void К_Click(object sender, EventArgs e)
        {
            guess = 'к';
            CheckLetter(guess);
            К.Enabled = false;
        }

        private void Л_Click(object sender, EventArgs e)
        {
            guess = 'л';
            CheckLetter(guess);
            Л.Enabled = false;
        }

        private void М_Click(object sender, EventArgs e)
        {
            guess = 'м';
            CheckLetter(guess);
            М.Enabled = false;
        }

        private void Н_Click(object sender, EventArgs e)
        {
            guess = 'н';
            CheckLetter(guess);
            Н.Enabled = false;
        }

        private void О_Click(object sender, EventArgs e)
        {
            guess = 'о';
            CheckLetter(guess);
            О.Enabled = false;
        }

        private void П_Click(object sender, EventArgs e)
        {
            guess = 'п';
            CheckLetter(guess);
            П.Enabled = false;
        }

        private void Р_Click(object sender, EventArgs e)
        {
            guess = 'р';
            CheckLetter(guess);
            Р.Enabled = false;
        }

        private void С_Click(object sender, EventArgs e)
        {
            guess = 'с';
            CheckLetter(guess);
            С.Enabled = false;
        }

        private void Т_Click(object sender, EventArgs e)
        {
            guess = 'т';
            CheckLetter(guess);
            Т.Enabled = false;
        }

        private void У_Click(object sender, EventArgs e)
        {
            guess = 'у';
            CheckLetter(guess);
            У.Enabled = false;
        }

        private void Ф_Click(object sender, EventArgs e)
        {
            guess = 'ф';
            CheckLetter(guess);
            Ф.Enabled = false;
        }

        private void Х_Click(object sender, EventArgs e)
        {
            guess = 'х';
            CheckLetter(guess);
            Х.Enabled = false;
        }

        private void Ц_Click(object sender, EventArgs e)
        {
            guess = 'ц';
            CheckLetter(guess);
            Ц.Enabled = false;
        }

        private void Ч_Click(object sender, EventArgs e)
        {
            guess = 'ч';
            CheckLetter(guess);
            Ч.Enabled = false;
        }

        private void Ш_Click(object sender, EventArgs e)
        {
            guess = 'ш';
            CheckLetter(guess);
            Ш.Enabled = false;
        }

        private void Щ_Click(object sender, EventArgs e)
        {
            guess = 'щ';
            CheckLetter(guess);
            Щ.Enabled = false;
        }

        private void Ъ_Click(object sender, EventArgs e)
        {
            guess = 'ъ';
            CheckLetter(guess);
            Ъ.Enabled = false;
        }

        private void Ы_Click(object sender, EventArgs e)
        {
            guess = 'ы';
            CheckLetter(guess);
            Ы.Enabled = false;
        }

        private void Ь_Click(object sender, EventArgs e)
        {
            guess = 'ь';
            CheckLetter(guess);
            Ь.Enabled = false;
        }

        private void Выход_Click(object sender, EventArgs e)
        {
            Close();
        }

  

        private void Э_Click(object sender, EventArgs e)
        {
            guess = 'э';
            CheckLetter(guess);
            Э.Enabled = false;
        }

        private void Ю_Click(object sender, EventArgs e)
        {
            guess = 'ю';
            CheckLetter(guess);
            Ю.Enabled = false;
        }

        private void Я_Click(object sender, EventArgs e)
        {
            guess = 'я';
            CheckLetter(guess);
            Я.Enabled = false;
        }

        //при пройгрыше показывает неоткрытые буквы в ответе
        public void Показатьответ_Click(object sender, EventArgs e)
        {
            string answerString = "";

            for (i = 0; i < charList.Count; i++)
            {
                answerString = answerString + char.ToString(charList[i]);
            }

            label1.Text = answerString;
        }

      

            
        
}
}

