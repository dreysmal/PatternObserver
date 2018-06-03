using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pattern_Observer
{
    public partial class Form1 : Form, IObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        public Direction Direction { get; private set; }
        public Form1()
        {
            InitializeComponent();
            var myButton1 = new MyButton(this)
            {
                Location = new Point(500, 300) 
            };
            var myButton2 = new MyButton(this)
            {
                Location = new Point(800, 400)
            };
            var myButton3 = new MyButton(this)
            {
                Location = new Point(1100, 500)
            };
            Controls.Add(myButton1);
            Controls.Add(myButton2);
            Controls.Add(myButton3);
            myButton1.Show();
            myButton2.Show();
            myButton3.Show();
        }
        
       public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(Direction);
            }
        }

        private void Up_Click(object sender, EventArgs e)
        {
            Direction = Direction.Up;
            NotifyObservers();
        }

        private void Right_Click(object sender, EventArgs e)
        {
            Direction = Direction.Right;
            NotifyObservers();
        }

        private void Down_Click(object sender, EventArgs e)
        {
            Direction = Direction.Down;
            NotifyObservers();
        }

        private void Left_Click(object sender, EventArgs e)
        {
            Direction = Direction.Left;
            NotifyObservers();
        }
    }

}
