﻿using Lab7_8.ViewModel.Comands;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Lab7_8.ViewModel
{
    public class ViewModel : INotifyPropertyChanged
    {
        public Command AddNewCommand { get; private set; }
        public Command DeleteCommand { get; private set; }
        public Command EditCommand { get; private set; }
        public Command SaveDescriptionCommand { get; private set; }
        public Command SortByStatusCommand { get; private set; }
        public Command SortByPriorityCommand { get; private set; }
        public Command SortByCategoryCommand { get; private set; }
        public Command UndoCommand { get; private set; }
        public Command RedoCommand { get; private set; }

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ListView _listView;


        public ViewModel(ListView listView)
        {
            AddNewCommand = new Command(AddNewTask);
            DeleteCommand = new Command(DeleteTask);
            EditCommand = new Command(EditTask);
            SaveDescriptionCommand = new Command(SaveTaskDescription);
            SortByPriorityCommand = new Command(SortByPriority);
            SortByStatusCommand = new Command(SortByStatus);
            SortByCategoryCommand = new Command(SortByCategory);
            UndoCommand = new Command(Undo);
            RedoCommand = new Command(Redo);
            _listView = listView;
            TaskDescriprion = "";
            Display();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void SortByCategory()
        {
            _listView.ItemsSource = (new DataBase()).GetMyTasks().OrderBy(x=>x.Category);
        }

        public void SaveTaskDescription()
        {
            MyTask temp = new MyTask(_selectedTask);
            temp.Description = TaskDescriprion;
            (new DataBase()).EditMyTask(_selectedTask, temp);
            Display();
        }

        public void Undo()
        {
            if(_undoTasks.Count!=0)
            {
                _deletedTask = _undoTasks.Pop();
                _redoTasks.Push(new MyTask(_deletedTask));
                (new DataBase()).AddMyTask(_deletedTask);
            }
            Display();
        }

        public void Redo()
        {
            if (_redoTasks.Count != 0)
            {
                _deletedTask = _redoTasks.Pop();
                _undoTasks.Push(new MyTask(_deletedTask));
                (new DataBase()).RemoveMyTask(_deletedTask);
            }
            Display();
        }

        public void SortByStatus()
        {
            var list = (new DataBase()).GetMyTasks();
            List<MyTask> listResult = new List<MyTask>();
            List<MyTask> temp = new List<MyTask>();

               temp = list.FindAll(x => x.Status == "In process");
            foreach (var item in temp)
            {
                listResult.Add(item);
            }

            temp = list.FindAll(x => x.Status == "Delay");
            foreach (var item in temp)
            {
                listResult.Add(item);
            }

            temp = list.FindAll(x => x.Status == "Complete");
            foreach (var item in temp)
            {
                listResult.Add(item);
            }

            _listView.ItemsSource = listResult;
        }

        public void SortByPriority()
        {
            var list = (new DataBase()).GetMyTasks();
            List<MyTask> listResult = new List<MyTask>();
            List<MyTask> temp = new List<MyTask>();

            temp = list.FindAll(x=>x.Priority == "High");
            foreach(var item in temp)
            {
                listResult.Add(item);
            }

            temp = list.FindAll(x=>x.Priority == "Medium");
            foreach(var item in temp)
            {
                listResult.Add(item);
            }

            temp = list.FindAll(x=>x.Priority == "Low");
            foreach(var item in temp)
            {
                listResult.Add(item);
            }

            _listView.ItemsSource = listResult;
        }

        public void AddNewTask()
        {
            (new AddNewTask()).ShowDialog();
            Display();
        }

        public void DeleteTask()
        {
            if (SelectedTask != null)
            {
                //_deletedTask = new MyTask(SelectedTask);
                _undoTasks.Push(new MyTask(SelectedTask));
                (new DataBase()).RemoveMyTask(SelectedTask);
            }
            else
            {
                MessageBox.Show("Please choose the task");
            }
            Display();
        }

        public void EditTask()
        {
            if (SelectedTask != null)
            {
                (new AddNewTask(_selectedTask)).ShowDialog();
            }
            else
            {
                MessageBox.Show("Please choose the task");
            }
            Display();
        }

        public void Display()
        {
            if (_redoTasks.Count == 0)
            {
                RedoEnable = false;
            }
            else
            {
                RedoEnable = true;
            }
            if (_undoTasks.Count == 0)
            {
                UndoEnable = false;
            }
            else
            {
                UndoEnable = true;
            }
            _listView.ItemsSource = (new DataBase()).GetMyTasks();
        }


        bool flagChoosed = true;
        private MyTask _selectedTask;
        private MyTask _deletedTask;

        private bool _redoEnable = false;
        private bool _undoEnable = false;
        public bool RedoEnable { get { return _redoEnable; } set { _redoEnable = value; NotifyPropertyChanged(""); } }
        public bool UndoEnable { get { return _undoEnable; } set { _undoEnable = value; NotifyPropertyChanged(""); } }

        private Stack<MyTask> _undoTasks= new Stack<MyTask>();
        private Stack<MyTask> _redoTasks= new Stack<MyTask>();

        public MyTask SelectedTask { get
            {
                return _selectedTask;
            }
            set
            {
                if (value != null)
                {
                    _selectedTask = (MyTask)value;
                    TaskDescriprion = value.Description;
                    flagChoosed = true;
                }
                else
                {
                    if (flagChoosed)
                    {
                        flagChoosed = false;
                    }
                    else
                    {
                        _selectedTask = null;
                        TaskDescriprion = "";
                    }
                } NotifyPropertyChanged(""); } }

         
        public string TaskDescriprion { get; set; }
    }
}