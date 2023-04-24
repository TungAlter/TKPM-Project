﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhongAccessDAL : DataAccessDAL
    {
        public List<Phong> Rooms = new List<Phong>();

        public List<Phong> Get_All_Phong()
        {
            Connection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select* from PHONG";
            command.Connection = connect;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string maph = reader.GetString(0);
                string tenph = reader.GetString(1);
                string loaiph = reader.GetString(2);
                int giathue = reader.GetInt32(3);
                int songuoi = reader.GetInt32(4);
                string trangthai = reader.GetString(5);
                bool tinhtrang = reader.GetBoolean(6);
                Phong Room = new Phong();
                Room.MaPhong = maph;
                Room.TenPhong = tenph;
                Room.LoaiPhong = loaiph;
                Room.GiaThue = giathue;
                Room.SoNguoi = songuoi;
                Room.TrangThai = trangthai;
                Room.TinhTrang = tinhtrang;
                Rooms.Add(Room);
            }
            reader.Close();
            return Rooms;
        }
    }
}