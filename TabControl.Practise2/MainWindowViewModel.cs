﻿using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Input;

namespace TabControl.Practise2
{
    public class MainWindowViewModel
    {
        public ICommand NewTabCommand { get; }
        private readonly ObservableCollection<ITab> tabs;
        public ObservableCollection<ITab> Tabs { get; }
        public int SelectedTabIndex { get; set; } 

        public MainWindowViewModel()
        {
            NewTabCommand = new DelegateCommand(NewTab);
            tabs = new ObservableCollection<ITab>();
            tabs.CollectionChanged += Tabs_CollectionChanged;
            Tabs = tabs;
            
            Tabs.Add(new DateTab());
        }
        ~MainWindowViewModel()
        {
            tabs.CollectionChanged -= Tabs_CollectionChanged;
        }

        private void NewTab(object obj)
        {
            Tabs.Add(new DateTab());
            SelectedTabIndex = Tabs.Count - 1;
        }

        private void Tabs_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            ITab tab;
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    tab = (ITab)e.NewItems[0];
                    tab.CloseRequested += OnTabCloseRequested;
                    break;
                case NotifyCollectionChangedAction.Remove:
                    tab = (ITab)e.OldItems[0];
                    tab.CloseRequested -= OnTabCloseRequested;
                    break;
            }
        }

        private void OnTabCloseRequested(object sender, EventArgs e)
        {
            Tabs.Remove((ITab)sender);
        }
    }
}
