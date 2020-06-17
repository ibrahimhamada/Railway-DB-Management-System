using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace RailWay
{
    public class Controller
    {
        private DBManager dbMan; // A Reference of type DBManager
                                 // (Initially NULL; NO DBManager Object is created yet)

        public Controller()
        {
            dbMan = new DBManager(); // Create the DBManager Object
        }

        //checks the username/password and returns the priviledges associated with this user
        //Returns 0 in case of error

        public int CheckPassword(string emailorname, string password)
        {
            //Query the DB to check for username/password
            string query = "SELECT priv from Users where (user_email = '" + emailorname + "' OR user_name = '" + emailorname + "') and password= '" + password + "';";
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return 0;
            else return (int)p;
        }

        public bool checkEmpid(int id)
        {
            //Query the DB to check for username/password
            string query = "SELECT employee_name from Employee where employee_id = " + id + ";";
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return false;
            else return true;
        }

        public bool checkSuperid(int id)
        {
            //Query the DB to check for username/password
            string query = "SELECT employee_name from Employee where super_ssn is NULL  and employee_id = " + id + ";";
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return false;
            else return true;
        }

        public bool checkUserid(int id)
        {
            //Query the DB to check for username/password
            string query = "SELECT user_name from Users where user_id = " + id + ";";
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return false;
            else return true;
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }


        /*stat_year int not null,
from_month int not null,
till_month int not null,
most_start_station varchar(30),
most_end_station varchar(30),
most_sex varchar(1),
most_month int,
most_trip int,
e_id int,*/
        public DataTable ViewStat(int yr, int FromMonth, int TillMonth)
        {
            string query = "SELECT most_start_station, most_end_station, most_sex, most_month FROM Statistic " +
                 "WHERE stat_year=" + yr + "and from_month=" + FromMonth + "and till_month=" +
                TillMonth + ";";
            return dbMan.ExecuteReader(query);
        }


        public string Viewmost_start_station(int yr, int FromMonth, int TillMonth)
        {
            string query = "SELECT most_start_station FROM Statistic " +
                 "WHERE stat_year=" + yr + "and from_month=" + FromMonth + "and till_month=" +
                TillMonth + ";";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string Viewmost_end_station(int yr, int FromMonth, int TillMonth)
        {
            string query = "SELECT most_end_station FROM Statistic " +
                 "WHERE stat_year=" + yr + "and from_month=" + FromMonth + "and till_month=" +
                TillMonth + ";";
            return (string)dbMan.ExecuteScalar(query);
        }

        public string Viewmost_sex(int yr, int FromMonth, int TillMonth)
        {
            string query = "SELECT most_sex FROM Statistic " +
                 "WHERE stat_year=" + yr + "and from_month=" + FromMonth + "and till_month=" +
                TillMonth + ";";
            return (string)dbMan.ExecuteScalar(query);
        }

        public int Viewmost_month(int yr, int FromMonth, int TillMonth)
        {
            string query = "SELECT most_month FROM Statistic " +
                 "WHERE stat_year=" + yr + "and from_month=" + FromMonth + "and till_month=" +
                TillMonth + ";";
            return (int)dbMan.ExecuteScalar(query);
        }

        public TimeSpan Viewmost_trip(int yr, int FromMonth, int TillMonth)
        {

            string query1 = "SELECT most_trip FROM Statistic " +
                 "WHERE stat_year= " + yr + " and from_month= " + FromMonth + " and till_month= " +
                TillMonth + ";";

            int trip = (int)dbMan.ExecuteScalar(query1);

            string query = "SELECT departue_time FROM Trip_Duration " +
                 "WHERE duration_id = " + trip + " ;";
            return (TimeSpan)dbMan.ExecuteScalar(query);

        }

        public DataTable Trips()
        {

            string query = "SELECT DISTINCT * FROM Trip_Duration ;";
            return dbMan.ExecuteReader(query);
        }


        public int UpdateStat1(int yr, int FM, int TM, int PSS, int PES, string PG, int M, int T, int id)
        {

            string query1 = "SELECT  station_name FROM Station Where station_num = " + PSS + "; ";

            string ss = (string)dbMan.ExecuteScalar(query1);

            string query2 = "SELECT  station_name FROM Station Where station_num = " + PES + "; ";

            string es = (string)dbMan.ExecuteScalar(query2);


            string query = "UPDATE Statistic SET most_start_station = '" + ss +
                "' , most_end_station = '" + es +
                "', most_sex = '" + PG +
                "', most_month = " + M +
                ", most_trip = " + T +
                ", e_id = " + id +
                " WHERE stat_year = " + yr + "and from_month = " + FM + "and till_month = "
                + TM + ";";



            return dbMan.ExecuteNonQuery(query);

        }

        public int UpdateStat(int yr, int FM, int TM, string PSS, string PES, string PG, int M, string T, int id)
        {
            string query = "UPDATE Statistic SET most_start_station = '" + PSS +
          "' , most_end_station = '" + PES +
          "', most_sex = '" + PG +
          "', most_month = " + M +
          ", most_departue_time = '" + T +
          "', e_id = " + id +
          " WHERE stat_year = " + yr + "and from_month = " + FM + "and till_month = "
          + TM + ";";
           return dbMan.ExecuteNonQuery(query);

        }


    public int InsertStat(int yr, int FM, int TM, int PSS, int PES, string PG, int M, int T, int id)
        {

            string query1 = "SELECT  station_name FROM Station Where station_num = " + PSS + "; ";

            string ss = (string)dbMan.ExecuteScalar(query1);

            string query2 = "SELECT  station_name FROM Station Where station_num = " + PES + "; ";

            string es = (string)dbMan.ExecuteScalar(query2);

            string query = "insert into Statistic values ( " + yr + ", " + FM + ", " + TM + ", '" +
                ss + "' , '" + es + "' , '" + PG + "' , " + M + ", " + T + "," +  id +" );";

            return dbMan.ExecuteNonQuery(query);

        }



        public int InsertPassenger(int passnum, string name, int age, string sex, int usernum)
        {
            string query = "insert into Passenger values ( " + passnum + ", '" + name + "', " + age + " , '" + sex + "', " + usernum + " );";
            return (int)dbMan.ExecuteNonQuery(query);

        }

        public int InsertPassengerEmp(int passnum, string name, int age, string sex)
        {
            string query = "insert into Passenger values ( " + passnum + ", '" + name + "', " + age + " , '" + sex + "', null );" ;
            return (int)dbMan.ExecuteNonQuery(query);

        }

        public int InsertNewPassenger(int passnum, int usernum)
        {

            string query1 = "SELECT user_name FROM Users WHERE user_id = " + usernum + ";";
            string name = (string)dbMan.ExecuteScalar(query1);

            string query2 = "SELECT user_sex FROM Users WHERE user_id = " + usernum + ";";
            string sex = (string)dbMan.ExecuteScalar(query2);

            string query3 = "SELECT user_age FROM Users WHERE user_id = " + usernum + ";";
            int age = (int)dbMan.ExecuteScalar(query3);


            string query = "insert into Passenger values ( " + passnum + ", '" + name + "', " + age + " , '" + sex + "', " + usernum + " );";
            return (int)dbMan.ExecuteNonQuery(query);

        }


        public int InsertTicketfromUser(int ticketnum, int tprice, string tickettype, string date, int durano,
            int usernum, int passnum, int FromSCB, int ToSCB, int tracknum)
        {

            string query = "insert into Ticket values ( " + ticketnum + ", " + tprice + ", '" + tickettype +"' , '" + date + "', " +
                durano + " , " + usernum + " , " + passnum + " , " + FromSCB + ", " + ToSCB + "," + tracknum + ", null );";
            return (int)dbMan.ExecuteNonQuery(query);

        }


        public int InsertTicketfromEmp(int ticketnum, int tprice, string tickettype, string date, int durano,
          int emp, int passnum, int FromSCB, int ToSCB, int tracknum)
        {

            string query = "insert into Ticket values ( " + ticketnum + ", " + tprice + ", '" + tickettype + "' , '" + date + "', " +
                durano + " , null , " + passnum + " , " + FromSCB + ", " + ToSCB + "," + tracknum + "," + emp + " );";
            return (int)dbMan.ExecuteNonQuery(query);

        }

        public DataTable DisStatYears()
        {
            string query = "SELECT DISTINCT stat_year FROM Statistic;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable DisStatFMonths(int year)
        {
            string query = "SELECT from_month FROM Statistic where stat_year = " + year + " ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable DisStatTMonths(int year)
        {
            string query = "SELECT  till_month FROM Statistic where stat_year = " + year + " ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable StationNames()
        {
            string query = "SELECT  * FROM Station;";
            return dbMan.ExecuteReader(query);
        }

        public int DeleteStat(int yr, int FM, int TM)
        {
            string query = "DELETE FROM Statistic WHERE stat_year= " + yr + " and from_month=  "
                + FM + " and till_month=" + TM + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable ViewAllTicketsDate(string date) // DGV
        {
            string query = "SELECT ticket_no As Ticket_Number, pass_name As Passenger_Name, ticket_type As Ticket_Type, resrve_date As Date_mm_dd_yyyy, " +
                 "track_name As Track_Name, station_name As Start_Station, departue_time As Departue_Time From " +
                 " Ticket, Track, Station, Trip_Duration, Passenger " +
                 " where resrve_date = '" + date + "' and pass_id = pass_no and track_num = track_n and  duration_id = trip_number and station_num = from_station ;";
            return dbMan.ExecuteReader(query);

        }


        public DataTable ViewAllTickets() // DGV
        {
           string query = "SELECT ticket_no As Ticket_Number, pass_name As Passenger_Name, ticket_type As Ticket_Type, resrve_date As Date_mm_dd_yyyy, " +
                "track_name As Track_Name, station_name As Start_Station, departue_time As Departue_Time From " +
                " Ticket, Track, Station, Trip_Duration, Passenger " +
                " where pass_id = pass_no and track_num = track_n and  duration_id = trip_number and station_num = from_station ;";
            return dbMan.ExecuteReader(query);

        }


        public DataTable ViewTicketsinformation(int userno) // DGV
        {


            string query = "SELECT ticket_no As Ticket_Number, pass_name As Passenger_Name, ticket_type As Ticket_Type, resrve_date As Date, " +
                "track_name As Track_Name, station_name As Start_Station, departue_time As Departue_Time From " +
                " Ticket, Track, Station, Trip_Duration, Passenger " +
                " where user_no = " + userno + " and pass_id = pass_no and track_num = track_n and  duration_id = trip_number and station_num = from_station ;";
            return dbMan.ExecuteReader(query);

        }
        public DataTable ViewTicketsDGV(int userno) // DGV
        {

            string query = "SELECT ticket_no FROM Ticket where user_no=" + userno;
            return dbMan.ExecuteReader(query);

        }

        public int passengerno(int userno) // DGV
        {
            string query = "SELECT pass_no FROM Ticket where user_no=" + userno +" ;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int passengernofromticket(int ticketno) // DGV
        {
            string query = "SELECT pass_no FROM Ticket where ticket_no =" + ticketno +" ;";
            if (dbMan.ExecuteScalar(query) == null)
            {
                return 0;
            }
            return (int)dbMan.ExecuteScalar(query);
        }

        public int CancelTicket(int ticketnum) // Setting user=Null
        {
            string query = "UPDATE Ticket SET user_no = NULL WHERE ticket_no=" + ticketnum;
            return dbMan.ExecuteNonQuery(query);
        }


        public int DeleteTicket(int ticketnum) // Setting user=Null
        {
            string query = "DELETE FROM Ticket WHERE ticket_no =  " + ticketnum + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int DeletePassenger(int passengerno) // Setting user=Null
        {
            string query = "DELETE FROM Passenger WHERE pass_id = " + passengerno + ";" ;
            return dbMan.ExecuteNonQuery(query);
        }


        public DataTable ViewTicketsCB(int userno) // ComboBox
        {
            string query = "SELECT ticket_no FROM Ticket where user_no = " + userno + ";";
            return dbMan.ExecuteReader(query);
        }



        /*  User */

        public DataTable ViewTracks() // ComboBox
        {

            string query = "SELECT track_num, track_name FROM Track;";
            return dbMan.ExecuteReader(query);
        }
        public int KnowTrackNum(string trackname) // To pass it to SelectTime Form
        {
            string query = "SELECT track_num FROM Track WHERE track_name = '" + trackname + "';";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable StationToTrack(int trackno) // ComboBox
        {
            string query = "SELECT station_name, station_num  FROM BELONGS , Station WHERE station_num = stat_num AND track_num= " + trackno + ";" ;  //Check
            return dbMan.ExecuteReader(query);
        }


        public int KnowStationNum(string stationname) // Setting user=Null
        {
            string query = "SELECT station_num  FROM Station WHERE station_name LIKE '" + stationname + "';";
            return dbMan.ExecuteNonQuery(query);
        }


        public int MaxTicketID()
        {
            string query = "SELECT MAX(ticket_no)  FROM Ticket;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int MaxPasstID() // Setting user=Null
        {
            string query = "SELECT MAX(pass_id)  FROM Passenger;";
            return (int)dbMan.ExecuteScalar(query);
        }

        /*
        public int trackfromstationname(string stationname) // Setting user=Null
        {
            string query = "SELECT track_num  FROM Station and BELONGS WHERE station_name = '" + stationname + "' and  LIKE '" + stationname + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        */

        /* Select Time Form */

        public DataTable SelectTimeDGV(int trackno) // DGV
        {
            string query = "SELECT duration_id, departue_time, arrival_time FROM Trip_Duration WHERE track_no = " + trackno + ";";
            return dbMan.ExecuteReader(query);

        }

        public DataTable SelectTimeCB() // DGV
        {
            string query = "SELECT  FROM ";
            return dbMan.ExecuteReader(query);

        }




        public int RetrieveStationID(string StaName)
        {
            string query = "SELECT station_num FROM Station" +
                "Where" +
                "station_name='" + StaName + "';";
            return dbMan.ExecuteNonQuery(query);
        }


        public DataTable ViewTrains()
        {
            string query = "SELECT * FROM Train;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewTracksInfo()
        {
            string query = "SELECT * FROM Track;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable ViewStationInfo(int TrackNum)
        {
            string query = "SELECT stat_num, station_order FROM BELONGS " +
                "WHERE track_num= " + TrackNum + ";";
            return dbMan.ExecuteReader(query);
        }



        public DataTable DriverIDs()
        {
            string query = "SELECT employee_id, employee_name FROM Employee " +
                "Where emp_role= 'D';";
            return dbMan.ExecuteReader(query);
        }

        public DataTable TripsInfo()
        {
            string query = "SELECT duration_id FROM Trip_Duration;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable TracksInfo()
        {
            string query = "SELECT track_num, track_name FROM Track;";
            return dbMan.ExecuteReader(query);
        }
        public int RetrieveTrackNum(int TripID)
        {
            string query = "SELECT track_no FROM Trip_Duration" +
                " Where" +
                " duration_id=" + TripID + ";";
            return dbMan.ExecuteNonQuery(query);
        }


        public DataTable BelongsTable(int tracknum)
        {
            string query = "SELECT * FROM  BELONGS " +
                "WHERE track_num=" + tracknum + ";";
            return dbMan.ExecuteReader(query);
        }

        public int InsertNewTrain(int Tno, int AvS, int yr, int duration, int DriverID, int TrackNum)
        {
            int Max = BelongsTable(TrackNum).Rows.Count;
            int SSID = (int)BelongsTable(TrackNum).Rows[0][1];
            int ESID = (int)BelongsTable(TrackNum).Rows[Max-1][1];
            string query = "INSERT INTO Train (train_no, available_seats, model_year, dura_id, driver_no, stop_station_id, start_station_id, track_num)" +
                            "Values (" + Tno + "," + AvS + "," + yr + "," + duration + "," + DriverID + "," + ESID +
             "," + SSID + "," + TrackNum + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable TrainsNumber()
        {
            string query = "SELECT DISTINCT train_no FROM Train;";
            return dbMan.ExecuteReader(query);
        }

        public int UpdateTrains(int Tno, int Seats, int Myr, int duration, int DriverID, int TrackNum)
        {
            int Max = BelongsTable(TrackNum).Rows.Count;
            int SSID = (int)BelongsTable(TrackNum).Rows[0][1];
            int ESID = (int)BelongsTable(TrackNum).Rows[Max - 1][1];
            string query = "UPDATE Train SET available_seats=" + Seats +
                ", model_year=" + Myr + ", dura_id=" + duration + ", driver_no=" +
                DriverID + ", stop_station_id=" + ESID + "," +
                " start_station_id=" + SSID + "," +
                " track_num=" + TrackNum + "WHERE" +
                " train_no=" + Tno + ";";


            return dbMan.ExecuteNonQuery(query);

        }
        public int DeleteTrain(int Tno)
        {
            string query = "DELETE FROM Train WHERE train_no=" + Tno +
                ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateBelongs(int TrackNum, int SNum, int SOrd)
        {

                string query = "UPDATE BELONGS SET track_num" + TrackNum +
                    ", stat_num=" + SNum + ", station_order=" + SOrd + ";";

                return dbMan.ExecuteNonQuery(query);

        }
        public int DeleteTrack(int TrackNum)
        {
            string query = "DELETE FROM Track WHERE track_num =" + TrackNum +
                ";";
            return dbMan.ExecuteNonQuery(query);
        }




        ///////////////////////////////////////////////////////////
        /* Employee Forms */
        /* || Send a Request Form||*/

        public int GetRequestID()
        {
            string query = "SELECT MAX(request_id) FROM Requests ;";
            return dbMan.ExecuteNonQuery(query);
        }
        public int GetRSuperSSN(int employeenum)
        {
            string query = "SELECT super_ssn  FROM Employee  WHERE employee_id = " + employeenum + ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertRequest(int request_id, string request, int e_id, int superssn, string req_status)
        {
            string query = "INSERT INTO Requests "
           + "Values(" + request_id + ",'" + request + "'," + e_id + "," + superssn + ",'" + req_status + "');";
            return dbMan.ExecuteNonQuery(query);
        }



        ///////////////////////////////////////////////////////////

        public int DeleteFromBelongs(int TrackNum)
        {
            string query = "DELETE FROM BELONGS WHERE track_num =" + TrackNum +
                ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable StationInfo()
        {
            string query = "SELECT * FROM Station;";
            return dbMan.ExecuteReader(query);
        }
        public int InsertNewTrack(int TrackNum, string TrackName)
        {

            string query = "INSERT INTO Track (track_num, track_name)" +
                            "Values (" + TrackNum + ",'" + TrackName + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertToBelongs(int TrackNum, int Order, int StationID)
        {

            string query = "INSERT INTO BELONGS (track_num, stat_num, station_order)" +
                            "Values (" + TrackNum + "," + StationID + "," + Order + ");";
            return dbMan.ExecuteNonQuery(query);
        }

        ///////////////////////////////////////////////////////////
        /* Admin new Form */
        /* ||   Show Available Requests Form    ||*/

        public DataTable ViewRequests(int empid)
        {
            string query = "SELECT request, req_status FROM Requests WHERE emp_id=" + empid+ " AND superssn IS NULL";
            return dbMan.ExecuteReader(query);
        }
        ///////////////////////////////////////////////////////////////////////
        public DataTable SelectMyTrain(int emp) // DGV
        {
            string query = "SELECT train_no As Train_Number, available_seats As Available_Seats, " +
              "model_year As Model_Year, departue_time As Departure_Time, track_num As Track_Number, station_name As Start_Station " +
              " FROM Train, Trip_Duration, Station WHERE " +
              "driver_no  = " + emp + " and duration_id = dura_id and station_num = start_station_id;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectTrainDGV(int trackno) // DGV
        {
            string query = "SELECT train_no As Train_Number, employee_name As Driver_Name, available_seats As Available_Seats, " +
              "model_year As Model_Year, departue_time As Departure_Time, station_name As Start_Station " +
              " FROM Train, Employee, Trip_Duration, Station WHERE " +
              " track_num = " + trackno + "and employee_id = driver_no and duration_id = dura_id and station_num = start_station_id ;";
            return dbMan.ExecuteReader(query);
        }

        public bool IsDriver(int empno) // DGV
        {
            string query = "SELECT  COUNT(*) FROM Employee WHERE " +
              " employee_id = " + empno + "and emp_role = 'D' ;";
            return false;
        }











        /* ||  USER Edit Password Form ||   */


        public string GetUserPassword(int userid)
        {
            string query = "SELECT password FROM Users " +
                 "WHERE user_id=" + userid + ";" ;

            return (string)dbMan.ExecuteScalar(query);
        }

        public int EditUserPassword(string newpass,int userid)
        {

            string query = "UPDATE Users SET password = '" + newpass + "' WHERE user_id=" + userid + ";";
            return dbMan.ExecuteNonQuery(query);
        }
        public int EditEmpPassword(string newpass, string pass)
        {

            string query = "UPDATE Users SET password = '" + newpass + "' WHERE password='" + pass + "' ;";
            return dbMan.ExecuteNonQuery(query);
        }





















































        ///////////////////////////////////////////////////////////////////////


        public int DeleteStation(int StationNum)
        {
            string query = "DELETE FROM Station WHERE station_num =" + StationNum +
                ";";
            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertNewStation(int StationNum, string StationName)
        {

            string query = "INSERT INTO Station (station_num, station_name)" +
                            "Values (" + StationNum + ",'" + StationName + "');";
            return dbMan.ExecuteNonQuery(query);
        }




        public int GetMaxUserID()
        {

            string query = "SELECT MAX(user_id) FROM Users ;";
            return (int)dbMan.ExecuteScalar(query);

        }
        public int SignUpUser(int userid, string Name, string Email, string Password, int Age, string Gender, int PhoneNum)
        {
            string query = "INSERT INTO Users(user_id, user_name, user_email, password, user_age, user_sex, user_phone, Priv)" +
                               "Values (" + userid + ",'" + Name + "','" + Email + "','" + Password + "'," + Age + ",'" + Gender + "'," + PhoneNum + "," + 2 + "); ";
            return dbMan.ExecuteNonQuery(query);
        }

        public int UpdateStation(int StationNum, string StationName)
        {

            string query = "UPDATE Station SET station_name='" + StationName +
               "' WHERE station_num=" + StationNum + ";";

            return dbMan.ExecuteNonQuery(query);

        }


        public int GetCapacity()
        {

            string query = "SELECT MAX(available_seats) FROM Train ;";
            return (int)dbMan.ExecuteScalar(query);

        }
        public int GetNumberOfTicket()
        {

            string query = "SELECT count(*) FROM Ticket ;";
            return (int)dbMan.ExecuteScalar(query);

        }

        public DataTable Tickets_Tracks()
        {
            string query = "SELECT track_n FROM Ticket GROUP BY track_n;";
            return dbMan.ExecuteReader(query);
        }
        
    }


}
