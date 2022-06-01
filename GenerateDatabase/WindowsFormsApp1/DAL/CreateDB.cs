using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO.DTO_Order;
using WindowsFormsApp1.DTO.DTO_Person;
using WindowsFormsApp1.DTO.DTO_PopcornDrink;
using WindowsFormsApp1.DTO.DTO_ShowTimes;

namespace WindowsFormsApp1
{
    public class CreateDB : DropCreateDatabaseAlways<QLCinema>
    {
        protected override void Seed(QLCinema context)
        {
            context._Customers.AddRange(new Customer[]
            {
                new Customer{ _IDPerson = "customer000001", _NamePerson = "NVA", _Phone = "0123123", _Address = "38 Do Anh Han", _Gender = true, _Birth = new DateTime(1999, 12, 25), _Username = "usernameKH1", _Password = "passwordKH1", _VIP = false},
                new Customer{ _IDPerson = "customer000002", _NamePerson = "NVB", _Phone = "0123124", _Address = "12 Truong Chinh", _Gender = true, _Birth = new DateTime(1960, 10, 26), _Username = "usernameKH2", _Password = "passwordKH2", _VIP = true},
                new Customer{ _IDPerson = "customer000003", _NamePerson = "NVC", _Phone = "0123125", _Address = "50 Tran Duy Hung", _Gender = true, _Birth = new DateTime(2002, 2, 1), _Username = "usernameKH3", _Password = "passwordKH3", _VIP = false},
                new Customer{ _IDPerson = "customer000004", _NamePerson = "NVD", _Phone = "0123126", _Address = "38 Nguyen Tat Thanh", _Gender = false, _Birth = new DateTime(1962, 12, 25), _Username = "usernameKH4", _Password = "passwordKH4", _VIP = true},
                new Customer{ _IDPerson = "customer000005", _NamePerson = "NVE", _Phone = "0123127", _Address = "21 Pham Ngu Lao", _Gender = false, _Birth = new DateTime(2000, 12, 15), _Username = "usernameKH5", _Password = "passwordKH5", _VIP = true},
                new Customer{ _IDPerson = "customer000006", _NamePerson = "NVF", _Phone = "0123128", _Address = "Nha Trang", _Gender = true, _Birth = new DateTime(1973, 12, 25), _Username = "usernameKH6", _Password = "passwordKH6", _VIP = false},
            });
            context._Employees.AddRange(new Employee[]
            {

                new Employee{ _IDPerson = "employee000001", _NamePerson = "NVA", _Phone = "0123123", _Address = "38 Do Anh Han", _Gender = true, _Birth = new DateTime(1999, 12, 25), _Username = "usernameNV1", _Password = "passwordNV1", _Shift = 1, _Wage = 5000000},
                new Employee{ _IDPerson = "employee000002", _NamePerson = "NVB", _Phone = "0123124", _Address = "12 Truong Chinh", _Gender = true, _Birth = new DateTime(1960, 10, 26), _Username = "usernameNV2", _Password = "passwordNV2", _Shift = 1, _Wage = 5000000},
                new Employee{ _IDPerson = "employee000003", _NamePerson = "NVC", _Phone = "0123125", _Address = "50 Tran Duy Hung", _Gender = true, _Birth = new DateTime(2002, 2, 1), _Username = "usernameNV3", _Password = "passwordNV3",  _Shift = 1, _Wage = 5000000},
                new Employee{ _IDPerson = "employee000004", _NamePerson = "NVD", _Phone = "0123126", _Address = "38 Nguyen Tat Thanh", _Gender = false, _Birth = new DateTime(1962, 12, 25), _Username = "usernameNV4", _Password = "passwordNV4",  _Shift = 1, _Wage = 5000000},
                new Employee{ _IDPerson = "employee000005", _NamePerson = "NVE", _Phone = "0123127", _Address = "21 Pham Ngu Lao", _Gender = false, _Birth = new DateTime(2000, 12, 15), _Username = "usernameNV5", _Password = "passwordNV5",  _Shift = 2, _Wage = 6000000},
                new Employee{ _IDPerson = "employee000006", _NamePerson = "NVF", _Phone = "0123128", _Address = "Nha Trang", _Gender = true, _Birth = new DateTime(1973, 12, 25), _Username = "usernameNV6", _Password = "passwordNV6", _Shift = 2, _Wage = 6000000},
            });
            context._Orders.AddRange(new Order[]
            {
                new Order{_IDOrder = "order00000001", _IDCustomer = "customer000001", _TimeOrder = new DateTime(2015, 12, 25), _Code = "sadad"},
                new Order{_IDOrder = "order00000002", _IDCustomer = "customer000002", _TimeOrder = new DateTime(2015, 12, 25), _Code = "sadafsq"},
                new Order{_IDOrder = "order00000003", _IDCustomer = "customer000003", _TimeOrder = new DateTime(2015, 12, 25), _Code = ""},
                new Order{_IDOrder = "order00000004", _IDCustomer = "customer000004", _TimeOrder = new DateTime(2015, 12, 25), _Code = ""},
                new Order{_IDOrder = "order00000005", _IDCustomer = "customer000005", _TimeOrder = new DateTime(2015, 12, 25), _Code = "werwet"},
            });
            context._PopcornDrinkOrders.AddRange(new PopcornDrinkOrder[]
            {
                new PopcornDrinkOrder{_IDPopcornDrinkOrder = "pdorder00000001", _IDOrder = "order00000001", _NamePopcornDrink = "Bap size S", _PopcornDrinkPrice = 10000, _Quantity = 2},
                new PopcornDrinkOrder{_IDPopcornDrinkOrder = "pdorder00000002", _IDOrder = "order00000001", _NamePopcornDrink = "Pepsi size L", _PopcornDrinkPrice = 20000, _Quantity = 1},
                new PopcornDrinkOrder{_IDPopcornDrinkOrder = "pdorder00000003", _IDOrder = "order00000002", _NamePopcornDrink = "Bap size L", _PopcornDrinkPrice = 20000, _Quantity = 2},
                new PopcornDrinkOrder{_IDPopcornDrinkOrder = "pdorder00000004", _IDOrder = "order00000002", _NamePopcornDrink = "Pepsi size M", _PopcornDrinkPrice = 18000, _Quantity = 1},
                new PopcornDrinkOrder{_IDPopcornDrinkOrder = "pdorder00000005", _IDOrder = "order00000003", _NamePopcornDrink = "Bap size S", _PopcornDrinkPrice = 10000, _Quantity = 2},
            });
            context._TicketOrders.AddRange(new TicketOrder[]
            {
                new TicketOrder{_IDTicketOrder = "ticketorder00000001", _IDOrder = "order00000001", _IDRoom = "room01",_Time = new DateTime(2022, 5, 1, 15, 30, 0) ,_SeatPurchased = "A1"},
                new TicketOrder{_IDTicketOrder = "ticketorder00000002", _IDOrder = "order00000002", _IDRoom = "room02",_Time = new DateTime(2022, 5, 1, 15, 30, 0) ,_SeatPurchased = "A1"},
                new TicketOrder{_IDTicketOrder = "ticketorder00000003", _IDOrder = "order00000003", _IDRoom = "room03",_Time = new DateTime(2022, 5, 1, 15, 30, 0) ,_SeatPurchased = "A1"},
                new TicketOrder{_IDTicketOrder = "ticketorder00000004", _IDOrder = "order00000004", _IDRoom = "room04",_Time = new DateTime(2022, 5, 1, 15, 30, 0) ,_SeatPurchased = "A1"},
                new TicketOrder{_IDTicketOrder = "ticketorder00000005", _IDOrder = "order00000005", _IDRoom = "room05",_Time = new DateTime(2022, 5, 1, 15, 30, 0) ,_SeatPurchased = "A1"},
            });
            context._ShowTimes.AddRange(new ShowTime[]
            {
                new ShowTime{_IDMovie = "movie000001", _IDRoom = "room01", _Seat = "1000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", _Time = new DateTime(2022, 5, 1, 15, 30, 0), _TicketPrice = 50000},
                new ShowTime{_IDMovie = "movie000002", _IDRoom = "room02", _Seat = "0110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", _Time = new DateTime(2022, 5, 1, 15, 30, 0), _TicketPrice = 50000},
                new ShowTime{_IDMovie = "movie000003", _IDRoom = "room03", _Seat = "0001110000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", _Time = new DateTime(2022, 5, 1, 15, 30, 0), _TicketPrice = 50000},
                new ShowTime{_IDMovie = "movie000004", _IDRoom = "room04", _Seat = "0000001111000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000", _Time = new DateTime(2022, 5, 1, 15, 30, 0), _TicketPrice = 50000},
                new ShowTime{_IDMovie = "movie000005", _IDRoom = "room05", _Seat = "0000000000111110000000000000000000000000000000000000000000000000000000000000000000000000000000000000", _Time = new DateTime(2022, 5, 1, 15, 30, 0), _TicketPrice = 50000},
            });
            context._Movies.AddRange(new Movie[]
            {
                new Movie{_IDMovie = "movie000001", _Actor = "NVA1, NVA2, NVA3,...", _Director = "NVD1", _Description = "Noi dung phim 1", _Category = "The loai 1, The loai 2", _Duration = new TimeSpan(2, 30, 20), _Rate = 5.0},
                new Movie{_IDMovie = "movie000002", _Actor = "NVA1, NVA2, NVA4,...", _Director = "NVD2", _Description = "Noi dung phim 2", _Category = "The loai 4, The loai 2", _Duration = new TimeSpan(3, 30, 20), _Rate = 5.0},
                new Movie{_IDMovie = "movie000003", _Actor = "NVA1, NVA3, NVA5,...", _Director = "NVD3", _Description = "Noi dung phim 3", _Category = "The loai 5", _Duration = new TimeSpan(2, 10, 20), _Rate = 5.0},
                new Movie{_IDMovie = "movie000004", _Actor = "NVA1, NVA4, NVA9,...", _Director = "NVD1", _Description = "Noi dung phim 4", _Category = "The loai 1, The loai 3", _Duration = new TimeSpan(1, 30, 20), _Rate = 5.0},
                new Movie{_IDMovie = "movie000005", _Actor = "NVA3, NVA2, NVA10,...", _Director = "NVD1", _Description = "Noi dung phim 5", _Category = "The loai 1, The loai 2", _Duration = new TimeSpan(4, 30, 20), _Rate = 5.0},

            });
            context._Rooms.AddRange(new Room[]
            {
                new Room{_IDRoom = "room01", _NameRoom = "Rap 1", _NumofSeats = 100},
                new Room{_IDRoom = "room02", _NameRoom = "Rap 2", _NumofSeats = 100},
                new Room{_IDRoom = "room03", _NameRoom = "Rap 3", _NumofSeats = 100},
                new Room{_IDRoom = "room04", _NameRoom = "Rap 4", _NumofSeats = 100},
                new Room{_IDRoom = "room05", _NameRoom = "Rap 5", _NumofSeats = 100},
            });
            context._PopcornDrinks.AddRange(new PopcornDrink[]
            {
                new PopcornDrink{_IDPopcornDrink = "pd0001", _NamePopcornDrink = "Bap size S", _PricePopcornDrink = 10000},
                new PopcornDrink{_IDPopcornDrink = "pd0002", _NamePopcornDrink = "Bap size M", _PricePopcornDrink = 18000},
                new PopcornDrink{_IDPopcornDrink = "pd0003", _NamePopcornDrink = "Bap size L", _PricePopcornDrink = 20000},
                new PopcornDrink{_IDPopcornDrink = "pd0004", _NamePopcornDrink = "Pepsi size S", _PricePopcornDrink = 10000},
                new PopcornDrink{_IDPopcornDrink = "pd0005", _NamePopcornDrink = "Pepsi size M", _PricePopcornDrink = 18000},
                new PopcornDrink{_IDPopcornDrink = "pd0006", _NamePopcornDrink = "Pepsi size L", _PricePopcornDrink = 20000},
            });
        }
    }
}
