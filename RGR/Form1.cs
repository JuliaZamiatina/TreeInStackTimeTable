using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace RGR
{
    public partial class Form1 : Form
    {

        CommonTimetable bigTimeTable = new CommonTimetable("Общее расписание"); //Общее расписание для потока
        Lesson bigCurrentElement = null;
        Timetable bigCurrentTimetable = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timetable AB320TimeTable = new Timetable("АБ-320", 100);
            CurrentTimeTableDetermination(AB320TimeTable);

            Timetable AB321TimeTable = new Timetable("АБ-321", 200);
            CurrentTimeTableDetermination(AB321TimeTable);

            Timetable ABs323TimeTable = new Timetable("АБс-323", 300);
            CurrentTimeTableDetermination(ABs323TimeTable);

            bigTimeTable.Root.Right = AB320TimeTable;
            bigTimeTable.Root.Right.Right = AB321TimeTable;
            bigTimeTable.Root.Right.Right.Right = ABs323TimeTable;
        } //Действия при загрузке формы
        public void CurrentTimeTableDetermination(Timetable currentTimeTable)
        {
            currentTimeTable.Root.Left = new Lesson("Понедельник", 10 + currentTimeTable.Root.Key);
            Lesson currentElement = currentTimeTable.Root.Left;
            for (int i = 1; i <= 6; i++)
            {
                currentElement.Right = new Lesson(null, currentElement.Key + 1);
                currentElement = currentElement.Right;
            }

            currentTimeTable.Root.Left.Left = new Lesson("Вторник", 20 + currentTimeTable.Root.Key);
            currentElement = currentTimeTable.Root.Left.Left;
            for (int i = 1; i <= 6; i++)
            {
                currentElement.Right = new Lesson(null, currentElement.Key + 1);
                currentElement = currentElement.Right;
            }

            currentTimeTable.Root.Left.Left.Left = new Lesson("Среда", 30 + currentTimeTable.Root.Key);
            currentElement = currentTimeTable.Root.Left.Left.Left;
            for (int i = 1; i <= 6; i++)
            {
                currentElement.Right = new Lesson(null, currentElement.Key + 1);
                currentElement = currentElement.Right;
            }

            currentTimeTable.Root.Left.Left.Left.Left = new Lesson("Четверг", 40 + currentTimeTable.Root.Key);
            currentElement = currentTimeTable.Root.Left.Left.Left.Left;
            for (int i = 1; i <= 6; i++)
            {
                currentElement.Right = new Lesson(null, currentElement.Key + 1);
                currentElement = currentElement.Right;
            }

            currentTimeTable.Root.Left.Left.Left.Left.Left = new Lesson("Пятница", 50 + currentTimeTable.Root.Key);
            currentElement = currentTimeTable.Root.Left.Left.Left.Left.Left;
            for (int i = 1; i <= 6; i++)
            {
                currentElement.Right = new Lesson(null, currentElement.Key + 1);
                currentElement = currentElement.Right;
            }

            currentTimeTable.Root.Left.Left.Left.Left.Left.Left = new Lesson("Суббота", 60 + currentTimeTable.Root.Key);
            currentElement = currentTimeTable.Root.Left.Left.Left.Left.Left.Left;
            for (int i = 1; i <= 6; i++)
            {
                currentElement.Right = new Lesson(null, currentElement.Key + 1);
                currentElement = currentElement.Right;
            }
        } //Определение основных ветвей расписания

        #region Контроль вида формы
        public void FirstViewControl()//Вид: общий первый. Добавить кнопку с текущим состоянием, удаление одного расписания, просмотр всего расписания
        {
            TheFirstChoice.Visible = !TheFirstChoice.Visible;
            CountingButton.Visible = !CountingButton.Visible;
            AddingButton.Visible = !AddingButton.Visible;
            AllDeletingButton.Visible = !AllDeletingButton.Visible;
            LessonLookingButton.Visible = !LessonLookingButton.Visible;
            DayLookingButton.Visible = !DayLookingButton.Visible;
            WeekLookingButton.Visible = !WeekLookingButton.Visible;
            DeleteLastButton.Visible = !DeleteLastButton.Visible;
            LastLessonDeletingButton.Visible = !LastLessonDeletingButton.Visible;
            AllTimeTableViewButton.Visible = !AllTimeTableViewButton.Visible;
        } 

        public void AddingViewControl()//Вид: добавление пары
        {
            GroupChoiseLabel.Visible = !GroupChoiseLabel.Visible;
            GroupChoiseList.Visible = !GroupChoiseList.Visible;
            WeekChoiceLabel.Visible = !WeekChoiceLabel.Visible;
            WeekChoiseList.Visible = !WeekChoiseList.Visible;
            LessonChoiceLabele.Visible = !LessonChoiceLabele.Visible;
            LessonChoiceUpDown.Visible = !LessonChoiceUpDown.Visible;
            NameChoiceLabel.Visible = !NameChoiceLabel.Visible;
            NameChoiceBox.Visible = !NameChoiceBox.Visible;
            AddLessonButton.Visible = !AddLessonButton.Visible;
            AddLessonLabel.Visible = !AddLessonLabel.Visible;
        }
        public void SpecificLessonViewControl()//Вид: просмотр конкретной пары
        {
            GroupChoiseLabel.Visible = !GroupChoiseLabel.Visible;
            GroupChoiseList.Visible = !GroupChoiseList.Visible;
            SpecificLessonLookingLabel.Visible = !SpecificLessonLookingLabel.Visible;
            WeekChoiceLabel.Visible = !WeekChoiceLabel.Visible;
            WeekChoiseList.Visible = !WeekChoiseList.Visible;
            LessonChoiceLabele.Visible = !LessonChoiceLabele.Visible;
            LessonChoiceUpDown.Visible = !LessonChoiceUpDown.Visible;
            SpecificLessonLookingButton.Visible = !SpecificLessonLookingButton.Visible;
        }
        public void DayViewControl()//Вид: просмотр расписания на день
        {
            GroupChoiseLabel.Visible = !GroupChoiseLabel.Visible;
            GroupChoiseList.Visible = !GroupChoiseList.Visible;
            DayLookingLabel.Visible = !DayLookingLabel.Visible;
            WeekChoiceLabel.Visible = !WeekChoiceLabel.Visible;
            WeekChoiseList.Visible = !WeekChoiseList.Visible;
            CurrentDayLookingButton.Visible = !CurrentDayLookingButton.Visible;
        }
        public void GroupCountintViewControl()//Вид: подсчет колличества пар
        {
            GroupChoiseLabel.Visible = !GroupChoiseLabel.Visible;
            GroupChoiseList.Visible = !GroupChoiseList.Visible;
            GroupCountingButton.Visible = !GroupCountingButton.Visible;
        }
        public void WeekLookingControl()// Вид: просмотр расписания на неделю
        {
            GroupChoiseLabel.Visible = !GroupChoiseLabel.Visible;
            GroupChoiseList.Visible = !GroupChoiseList.Visible;
            CurrentWeekLookingButton.Visible = !CurrentWeekLookingButton.Visible;
        }
        public void AllTimeTableViewControl()
        {
            ViewLabel.Visible = !ViewLabel.Visible;
            LeftButton.Visible = !LeftButton.Visible;
            RightButton.Visible = !RightButton.Visible;
            ReturnButton.Visible = !ReturnButton.Visible;
        }
        #endregion

        #region Работа с первым видом
        private void AddingButton_Click(object sender, EventArgs e)//Переход в добавление пары 
        {
            FirstViewControl();
            AddingViewControl();
            NameChoiceBox.Text = null;
        }
        private void CountingButton_Click(object sender, EventArgs e)//Подсчет всех пар
        {
            FirstViewControl();
            GroupCountintViewControl();           
        }
        private void AllDeletingButton_Click(object sender, EventArgs e)// Удаление всего
        {
            bigTimeTable.Clear();
            MessageBox.Show("Расписание успешно очищено.");
        }
        private void LessonLookingButton_Click(object sender, EventArgs e)// Переход в просмотр пары
        {
            FirstViewControl();
            SpecificLessonViewControl();
        }
        private void DayLookingButton_Click(object sender, EventArgs e)// Переход в просмотр расписания на день
        {
            FirstViewControl();
            DayViewControl();
        }
        private void WeekLookingButton_Click(object sender, EventArgs e)// Переход в просмотр расписания недели
        {
            FirstViewControl();
            WeekLookingControl();
        }
        private void DeleteLastButton_Click(object sender, EventArgs e)//Удаление последнего расписания
        {
            bigTimeTable.Pop();
            MessageBox.Show("Последнее расписание успешно удалено.");
        }
        private void LastLessonDeletingButton_Click(object sender, EventArgs e)//Удаление последней пары
        {
            bool IsFull = false;
            int groupPopKey = 0;

            foreach (Timetable t in bigTimeTable)
            {
                foreach (Lesson l in t)
                {
                    if (l.Key % 10 != 0)
                    {
                        if (l.Value != null)
                        {
                            IsFull = true;
                        }
                    }
                }
                if (IsFull)
                {
                    groupPopKey = t.Root.Key;
                }
                IsFull = false;
            }

            foreach (Timetable t in bigTimeTable)
            {
                if (t.Root.Key == groupPopKey)
                    t.Pop();
            }

            MessageBox.Show("Последняя пара успешно удалена");
        }
        #endregion


        private void AddLessonButton_Click(object sender, EventArgs e)// Добавление пары
        {
            if (GroupChoiseList.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбрана группа!");
                return;
            }
            if (WeekChoiseList.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран день недели!");
                return;
            }
            if (NameChoiceBox.Text == null)
            {
                MessageBox.Show("Не выбрано название пары!");
                return;
            }
            
            int key = (GroupChoiseList.SelectedIndex + 1)*100 + (WeekChoiseList.SelectedIndex + 1) * 10;
            key += (int)LessonChoiceUpDown.Value;

            foreach (Timetable t in bigTimeTable)
            {
                if (t.Root.Key == (key/100)*100)
                {
                    t.Add(NameChoiceBox.Text, key);
                    MessageBox.Show("Пара добавлена.");
                };
            };
            

            FirstViewControl();
            AddingViewControl();
        }
        private void SpecificLessonLookingButton_Click(object sender, EventArgs e)//Просмотр пары
        {
            if (GroupChoiseList.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбрана группа!");
                return;
            }
            if (WeekChoiseList.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран день недели!");
                return;
            }

            int key = (GroupChoiseList.SelectedIndex + 1) * 100 + (WeekChoiseList.SelectedIndex + 1) * 10 + (int)LessonChoiceUpDown.Value;
            string s = null;
            foreach (Timetable t in bigTimeTable)
            {
                if (t.Root.Key == (GroupChoiseList.SelectedIndex + 1) * 100)
                {
                    s = t.Show(key);
                }
            }
            MessageBox.Show(s);

            FirstViewControl();
            SpecificLessonViewControl();
        }
        private void CurrentDayLookingButton_Click(object sender, EventArgs e)// Просмотр дня недели
        {
            if (GroupChoiseList.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбрана группа!");
                return;
            }
            if (WeekChoiseList.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран день недели!");
                return;
            }

            string s = null;
            int weekKey = (WeekChoiseList.SelectedIndex + 1);
            int groupKey = (GroupChoiseList.SelectedIndex + 1) * 100;

            foreach (Timetable t in bigTimeTable)
            {
                if (t.Root.Key == groupKey)
                {
                    foreach (Lesson l in t)
                    {
                        if ((l.Key % 100) / 10 == weekKey)
                        {
                            if (l.Value != null)
                            {
                                if (l.Key%10==0)
                                {
                                    s += l.Value + ": \r\n";
                                }
                                else
                                    s += "\t" +(l.Key % 10).ToString() + ". " + l.Value + "\r\n";
                            }
                        }
                    }
                }
            }

            if (s == null)
            {
                MessageBox.Show("Нет пар");
                FirstViewControl();
                DayViewControl();
                return;
            }

            MessageBox.Show(s);
            FirstViewControl();
            DayViewControl();
        }

        private void GroupCountingButton_Click(object sender, EventArgs e)//Подсчет колличества пар у группы
        {
            if (GroupChoiseList.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбрана группа!");
                return;
            }

            int size = 0;
            foreach(Timetable t in bigTimeTable)
            {
                if(t.Root.Key == (GroupChoiseList.SelectedIndex + 1)*100)
                {
                    size = t.Size();
                }
            }            
            MessageBox.Show("На этой неделе у группы " + GroupChoiseList.SelectedItem +" "+ size.ToString() + " пар(ы)");
            FirstViewControl();
            GroupCountintViewControl();
        }

        private void CurrentWeekLookingButton_Click(object sender, EventArgs e)//Просмотр расписания на неделю
        {
            if (GroupChoiseList.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбрана группа!");
                return;
            }

            string s = null;
            foreach (Timetable t in bigTimeTable)
            {
                if (t.Root.Key == ((GroupChoiseList.SelectedIndex+1)*100))
                {
                    foreach(Lesson l in t)
                    {
                        if (l.Value != null)
                            if ((l.Key%10)==0)
                            {
                                s += l.Value + ": \r\n";
                            }
                            else
                            {
                                s +="\t" + (l.Key % 10).ToString() +". " + l.Value + "\r\n";
                            }
                    }
                }
            }

            MessageBox.Show(s);
            FirstViewControl();
            WeekLookingControl();

        }

        private void AllTimeTableViewButton_Click(object sender, EventArgs e)
        {
            FirstViewControl();
            AllTimeTableViewControl();
            bigCurrentElement = bigTimeTable.Root.Root;
            bigCurrentTimetable = bigTimeTable.Root;
        }

        #region Общий просмотр расписания
        private void LeftButton_Click(object sender, EventArgs e)
        {
            if(bigCurrentElement.Key/100 == 0)
            {
                MessageBox.Show("Невозможно перейти левее");
                return;
            }
            if (bigCurrentElement.Key % 10 != 0)
            {
                MessageBox.Show("Невозможно перейти левее");
                return;
            }
            if ((bigCurrentElement.Key % 100)/10 == 6)
            {
                MessageBox.Show("Невозможно перейти левее");
                return;
            }
            if (bigCurrentElement.Left != null)
                bigCurrentElement = bigCurrentElement.Left;
            else 
                if (bigCurrentTimetable.Left != null)
                {
                    bigCurrentTimetable = bigCurrentTimetable.Left;
                    bigCurrentElement = bigCurrentTimetable.Root;
                }

            if (bigCurrentElement.Value == null)
                ViewLabel.Text = "Не заполнено";
            else
                ViewLabel.Text = bigCurrentElement.Value;
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if (bigCurrentElement.Key % 10 == 6)
            {
                MessageBox.Show("Невозможно перейти правее");
                return;
            }
            if (bigCurrentElement.Key % 100 == 60)
            {
                MessageBox.Show("Невозможно перейти правее");
                return;
            }
            if (bigCurrentElement.Key/100 == 3)
            {
                MessageBox.Show("Невозможно перейти правее");
                return;
            }


            if (bigCurrentElement.Right != null)
                bigCurrentElement = bigCurrentElement.Right;
            else
                if (bigCurrentTimetable.Right != null)
                {
                    bigCurrentTimetable = bigCurrentTimetable.Right;
                    bigCurrentElement = bigCurrentTimetable.Root;
                }

            if (bigCurrentElement.Value == null)
                ViewLabel.Text = "Не заполнено";
            else
                ViewLabel.Text = bigCurrentElement.Value;    
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            bigCurrentTimetable = bigTimeTable.Root;
            bigCurrentElement = bigCurrentTimetable.Root;
            ViewLabel.Text = bigCurrentElement.Value;
        }
        #endregion


    }

    #region Определение классов
    public abstract class MyElement<T>// Абстрактный параметризированный класс узла бинарного дерева
    {
        protected string data;// Значение
        protected T left;// Левый узел
        protected T right;// Правый узел
        protected int key;// Ключ для поиска

        public abstract int Key
        {
            get;
            set;
        }
        public string Value
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            } 
        }

        abstract public T Left
        {
            get;
            set;
        }
        abstract public T Right
        {
            get;
            set;
        }

    }
    public class Lesson : MyElement<Lesson>// Рабочий класс "пара"
    {
        public Lesson()
        {
            this.Value = null;
            this.Key = 0;
        }
        public Lesson(string s, int k)
        {
            this.Value = s;
            this.Key = k;
        }

        public override Lesson Left
        {
            get
            {
                if (this.left == null)
                    return null;
                return this.left;
            }
            set
            {
                if (this.left == null)
                    this.left = new Lesson();
                this.left = value;
            }
        }
        public override Lesson Right
        {
            get
            {
                if (this.right == null)
                    return null;
                return this.right;
            }
            set
            {
                if (this.right == null)
                    this.right = new Lesson();
                this.right = value;
            }
        }
        public override int Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }
        }

    }
    interface Stack// Интерфейс, обязательный для реализации в стэке
    {
        void Clear();// Очистка стэка
        void Add(string what, int key);// Добавление элемента
        void Pop();// Удаление последнего элемента
        int Size();// Размер стэка
        string Show(int key);// Просмотр элемента без удаления

    }
    public  abstract class MyStack<T>: Stack// Абстрактный параметризированный класс бинарного дерева, реализующего функции стэка
    {
        public T root;// Корень дерева

        public T Root
        {
            get
            {
                return root;
            }
            set
            {
                root = value;
            }
        }
        
        public virtual void Clear()
        {
        }
        public virtual void Add(string value, int key)
        {
        }
       
        public virtual void Pop()
        {
        }

        public virtual int Size()
        {
            return 0;
        }
        public virtual string Show(int key)
        {           
            return null;
        }

        public virtual MyStackEnumerator GetEnumerator()// Функция вызова счетчика
        {
            return new MyStackEnumerator(this);
        }

        public class MyStackEnumerator// Сам шаблон счетчика
        {
            protected int key = 0;// Ключ
            protected MyStack<T> t;// Место поиска
            protected bool IsCounting = true;// Переменные, отвечающие за продолжение подсчета
            protected bool BigIsCounting = true;

            public MyStackEnumerator()
            { 
            }
            public MyStackEnumerator(MyStack<T> t)
            {
                this.t = t;
            }
            public virtual bool MoveNext()
            {
                return false;
            }// Переход к следующему элементу

            public virtual void Reset()
            {
                key = 0;
            }// Сброс

            public virtual T Current
            {
                get { return Current; }
            }// Текущий элемент
        }

    }
    public class Timetable: MyStack<Lesson>// Рабочий класс "расписание"
    {
        private Timetable right;// Дерево справа
        private Timetable left;// Дерево слева

        public Timetable Right
        {
            get
            {
                if (this.right == null)
                    return null;
                return this.right;
            }
            set
            {
                if (this.right == null)
                    this.right = new Timetable();
                this.right = value;
            }
        }
        public Timetable Left
        {
            get
            {
                if (this.left == null)
                    return null;
                return this.left;
            }
            set
            {
                if (this.left == null)
                    this.left = new Timetable();
                this.left = value;
            }
        }

        public Timetable()
        {
            this.Root = null;
        }
        public Timetable(string s, int key)
        {
            this.Root = new Lesson(s, 0);
            this.Root.Key = key;
        }

        public override void Clear()
        {
            foreach (Lesson element in this)
                if ((element.Key % 10) != 0)
                    element.Value = null;
        }
        public override void Add(string value, int key)
        {
            foreach (Lesson element in this)
            {
                if (element.Key == key)
                {
                    element.Value = value;
                }
            }
        }
        public override void Pop()
        {
            int popKey = 0;

            foreach (Lesson element in this)
            {
                if (element.Value != null)
                    if ((element.Key >= popKey) && (element.Key % 10 != 0))
                        popKey = element.Key;
            }
            foreach (Lesson element in this)
            {
                if (element.Key == popKey)
                    element.Value = null;
            }
        }
        public override int Size()
        {
            int size = 0;
            foreach (Lesson element in this)
                if ((element.Value != null)&&(element.Key%10 != 0))
                    size++;
            return size; 
        }
        public override string Show(int key)
        {
            foreach (Lesson element in this)
            {
                if (element.Key == key)
                    if (element.Value != null)
                        return element.Value;
                    else return "Нет пары";
            }
            return null;
        }
        public override MyStackEnumerator GetEnumerator()
        {
            return new TimetableEnumerator(this);
        }

        public class TimetableEnumerator:MyStackEnumerator
        {
            public TimetableEnumerator(Timetable t)
            {
                this.t = t;
            }
            
            public override bool MoveNext()
            {
                if ((Current.Right != null)&&(Current.Key % 100 != 0))
                    {
                        key++;
                        return true;
                    }
                if (IsCounting)
                {
                    key += 10 - (key % 10);
                    return true;
                }
                return false;
            }
            public override Lesson Current
            {
                get
                {
                    Lesson current = t.Root;
                    int vrem = (key % 100) / 10;

                    for (int i = 0; i < vrem; i++)
                        current = current.Left;

                    if (current.Left == null)
                    {
                        IsCounting = false;
                    }

                    vrem = key % 10;
                    for (int i = 0; i < vrem; i++)
                        current = current.Right;
                    return current;
                }
            }

        }
    }
    public class CommonTimetable: MyStack<Timetable>
    {
        public CommonTimetable()
        {
            this.Root = null;
        }
        public CommonTimetable(string element)
        {
            this.Root = new Timetable(element, 000);
        }

        public override void Add(string value, int Parentkey)
        {
            foreach (Timetable element in this)
                if (element.Root.Key == Parentkey)
                {
                    element.Right = new Timetable(value, Parentkey+100);
                }
        }
        public override void Pop()
        {
            int popKey = 0;
            bool IsFull = false;

            foreach (Timetable t in this)
            {
                if (t.Root.Value != null)
                    if (t.Root.Key >= popKey)
                    {
                        foreach (Lesson l in t)
                        {
                            if (l.Key % 10 != 0)
                            {
                                if (l.Value != null)
                                {
                                    IsFull = true;
                                }
                            }
                        }

                        if (IsFull)
                        {
                            popKey = t.Root.Key;
                        }

                        IsFull = false;
                    }
            }
            foreach (Timetable t in this)
            {
                if (t.Root.Key / 100 == popKey / 100)
                    t.Clear();
            }
        }
        public override void Clear()
        {
            foreach (Timetable t in this)
            {
                t.Clear();
            }
        }
        public override int Size()
        {
            int size = 0;
            foreach (Timetable t in this)
            {
                size += t.Size();
            }
            return size;
        }
        public override MyStackEnumerator GetEnumerator()
        {
            return new CommonTimetableEnumerator(this);
        }

        public class CommonTimetableEnumerator : MyStackEnumerator
        {
            public CommonTimetableEnumerator(CommonTimetable t)
            {
                this.t = t;
            }

            public override bool MoveNext()
            {
                if (Current.Right != null)
                {
                    key+=100;
                    return true;
                }
                return false;
            }
            public override Timetable Current
            {
                get
                {
                    Timetable current = t.Root;
                    int vrem = key/100;

                    for (int i = 0; i < vrem; i++)
                        current = current.Right;
                    return current;
                }
            }

        }

    }
    #endregion
    
}
