﻿using RoomLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RoomsArea
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Room room = new Room();
        Office office = new Office();
        LivingRoom livingRoom = new LivingRoom();
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Room> lstRooms = new List<Room>(); // Создание списка комнат 

        private void BAddRoom_Click(object sender, RoutedEventArgs e)
        {
            Room room = new Room();
            room.RoomLength = Convert.ToDouble(TBLengthR.Text);
            room.RoomWidth = Convert.ToDouble(TBWidthR.Text);
            lstRooms.Add(room);
        }

        private void BAddLivingRoom_Click(object sender, RoutedEventArgs e)
        {
            LivingRoom livingRoom = new LivingRoom();
            livingRoom.RoomLength = Convert.ToDouble(TBLengthL.Text);
            livingRoom.RoomWidth = Convert.ToDouble(TBWidthL.Text);
            livingRoom.NumWin = Convert.ToInt32(TBNumW.Text);
            lstRooms.Add(livingRoom);
        }

        private void BAddOffice_Click(object sender, RoutedEventArgs e)
        {
            Office office = new Office();
            office.RoomLength = Convert.ToDouble(TBLengthO.Text);
            office.RoomWidth = Convert.ToDouble(TBWidthR.Text);
            office.NumSockets = Convert.ToInt32(TBNumS.Text);
            lstRooms.Add(office);
        }

        private void BGetList_Click(object sender, RoutedEventArgs e)
        {
            ListRooms.Content = "";
            foreach (Room r in lstRooms)
                ListRooms.Content += r.Info() + "\n";
        }
    }
}
