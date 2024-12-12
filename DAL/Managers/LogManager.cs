//using DAL.Contexts;
//using DAL.Entities;
//using DAL.Interfaces;
//using DAL.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DAL.Managers
//{
//    public class LogManager : ILogManager
//    {
//        private readonly UserDbContext _context;

//        public LogManager(UserDbContext context)
//        {
//            _context = context;
//        }

//        public async Task InsertLog(Exception exception, string func)
//        {

//            try
//            {
//                //userslog l = new userslog(exception.Message, " User " + func);
//                await _context.Users.AddAsync(l);
//                await _context.SaveChangesAsync();
//            }
//            catch (Exception ex)
//            {
//                WriteToLogFile(ex.ToString());
//            }
//        }

//        public async Task InsertLog(string action, string data)
//        {

//            try
//            {
//                //userslog l = new userslog(data, "User Log Manager " + action);
//                //await _context.Users.AddAsync(l);
//                //await _context.SaveChangesAsync();
//            }
//            catch (Exception ex)
//            {
//                WriteToLogFile(ex.ToString());
//            }
//        }

//        private void WriteToLogFile(string msg)
//        {
//            string currentDateDirectory = "Logs";
//            string path = currentDateDirectory;
//            string fileName = DateTime.Now.ToString("ddMMyy") + "errorLog.txt";

//            string pathWithFileName = path + "\\" + fileName;

//            if (!Directory.Exists(path))
//            {
//                Directory.CreateDirectory(path);
//            }
//            using (StreamWriter sw = File.AppendText(pathWithFileName))
//            {
//                sw.WriteLine(msg + ";" + Environment.NewLine);
//            }
//        }
//    }
//}
