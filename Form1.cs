using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooplab41
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Кол-во ячеек в хранилище
        static int av = 5;

        // Создаем хранилище
        Container container = new Container(av);

        // Счетчик отображаемых объектов
        static int index = 0;

        // Индекс элемента хранилища
        int indexC = 0;

        // Идентификатор нажатия Control
        int ctrlPressed = 0;

        class Circle
        {
            public int x, y;
            public int r = 20;
            public Color color = Color.Maroon;
            public bool visible = true;

            public Circle()
            {
                x = 0;
                y = 0;
            }

            public Circle(int x, int y)
            {
                this.x = x - r;
                this.y = y - r;
            }

            ~Circle() { }

        }

        class Container {
            public Circle[] m_data;

            public Container(int count)
            {
                m_data = new Circle[count];
                for (int i = 0; i < count; ++i)
                {
                    m_data[i] = null;
                }
            }

            public void place(int count)
            {
                m_data = new Circle[count];
                for (int i = 0; i < count; ++i)
                {
                    m_data[i] = null;
                }
            }

            public void add_object(int ind, ref Circle object1, int count, ref int indexC)
            {
                while (m_data[ind] != null)
                {
                    ind = (ind + 1) % count;
                }
                m_data[ind] = object1;
                indexC = ind;
            }

            public void deleter(int ind)
            {
                m_data[ind] = null;
                index--;
            }

            public bool emptynessCheck(int index)
            {
                if (m_data[index] == null)
                {
                    return true;
                }
                else return false;
            }

            public int oc(int size)
            {
                int count_oc = 0;
                for (int i = 0; i < size; ++i)
                {
                    if (!emptynessCheck(i))
                    {
                        ++count_oc;
                    }
                }
                return count_oc;
            }

            public void Dsize(ref int size)
            {
                Container storage1 = new Container(size * 2);
                for (int i = 0; i < size; ++i)
                {
                    storage1.m_data[i] = m_data[i];
                }
                for (int i = size; i < (size * 2) - 1; ++i)
                {
                    storage1.m_data[i] = null;
                }
                size = size * 2;
                place(size);
                for (int i = 0; i < size; i++)
                {
                    m_data[i] = storage1.m_data[i];
                }
            }

            ~Container() { }
        }


        private void paint_circle(Color name, ref Container stg, int index)
        {
            Pen pen = new Pen(name, 3);
            if (!container.emptynessCheck(index))
            {
                if (container.m_data[index].visible == true)
                {
                    PanelD.CreateGraphics().DrawEllipse(
                    pen,
                    stg.m_data[index].x,
                    stg.m_data[index].y,
                    stg.m_data[index].r * 2,
                    stg.m_data[index].r * 2);
                    stg.m_data[index].color = name;
                }
            }
        }
        private void remove_selection_circle(ref Container stg)
        {   // Снимает выделение у всех элементов хранилища
            for (int i = 0; i < av; ++i)
            {
                if (!container.emptynessCheck(i))
                {   // Вызываем функцию отрисовки круга
                    paint_circle(Color.Maroon, ref container, i);
                }
            }
        }

        private void remove_selected_circle(ref Container stg)
        {   // Удаляет выделенные элементы из хранилища
            for (int i = 0; i < av; ++i)
            {
                if (!container.emptynessCheck(i))
                {
                    if (container.m_data[i].color == Color.LimeGreen)
                    {
                        container.deleter(i);
                    }
                }
            }
        }

        private int check_circle(ref Container stg, int size, int x, int y)
        {   // Проверяет есть ли уже круг с такими же координатами в хранилище
            if (stg.oc(size) != 0)
            {
                for (int i = 0; i < size; ++i)
                {
                    if (!stg.emptynessCheck(i))
                    {
                        int x1 = stg.m_data[i].x - 15;
                        int x2 = stg.m_data[i].x + 15;
                        int y1 = stg.m_data[i].y - 15;
                        int y2 = stg.m_data[i].y + 15;

                        // Если круг есть, возвращет индекс круга в хранилище
                        if ((x1 <= x && x <= x2) && (y1 <= y && y <= y2))
                            return i;
                    }
                }
            }
            return -1;
        }

        private void PanelD_MouseClick(object sender, MouseEventArgs e)
        {
            Circle circle1 = new Circle(e.X, e.Y);
            if (index == av)
            {
                container.Dsize(ref av);
            }
            int c = check_circle(ref container, av, circle1.x, circle1.y);
            if (c != -1)
            {
                if (Control.ModifierKeys == Keys.Control)
                {
                    if (ctrlPressed == 0)
                    {
                        paint_circle(Color.Maroon, ref container, indexC);
                        ctrlPressed = 1;
                    }
                    paint_circle(Color.LimeGreen, ref container, c);
                }
                else
                {
                    remove_selection_circle(ref container);
                    paint_circle(Color.LimeGreen, ref container, c);
                }
                return;
            }
            container.add_object(index, ref circle1, av, ref indexC);
            remove_selection_circle(ref container);
            paint_circle(Color.LimeGreen, ref container, indexC);
            ++index;
            ctrlPressed = 0;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            PanelD.Refresh();
            for (int i = 0; i < av; ++i)
            {
                if (!container.emptynessCheck(i))
                {
                    container.m_data[i].visible = false;
                }
            }
        }

        private void ClearSelected_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < av; ++i)
            {
                container.m_data[i] = null;
            }
            index = 0;
            PanelD.Refresh();
        }

        private void DeleteCB_Click(object sender, EventArgs e)
        {
            remove_selected_circle(ref container);
            PanelD.Refresh();
            if (container.oc(av) != 0)
            {
                for (int i = 0; i < av; ++i)
                {
                    paint_circle(Color.Maroon, ref container, i);
                }
            }
        }

        private void ShowB_Click(object sender, EventArgs e)
        {
            PanelD.Refresh();
            if (container.oc(av) != 0)
            {
                for (int i = 0; i < av; ++i)
                {
                    if (!container.emptynessCheck(i))
                    {
                        container.m_data[i].visible = true;
                    }
                    paint_circle(Color.Maroon, ref container, i);
                }
            }
        }
    }
}
