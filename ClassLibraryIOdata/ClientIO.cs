using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ClassLibraryBusinessRules;

namespace ClassLibraryIOdata
{
    public class ClientIO
    {
        const string dir = @"";
        const string filePathClient = dir + "Client.txt";
        const string filePathClientMod = dir + "TempClient.txt";

        public static void SaveClient(ClsClient cli, out string msg)
        {
            StreamWriter sWriter = new StreamWriter(new FileStream(filePathClient, FileMode.Append, FileAccess.Write));
            sWriter.WriteLine(cli.ToString());
            msg = "The client was created.";
            sWriter.Close();
        }

        public static List<ClsClient> GetListClient(){
            List<ClsClient> listClient = new List<ClsClient>();
            StreamReader sReader = new StreamReader(filePathClient);
            string line = sReader.ReadLine();
            while(line != null){
                ClsClient cli = new ClsClient();
                string[] field = line.Split('|');
                cli.ClientId = Convert.ToUInt16(field[0]);
                cli.Name = new ClsFullName(field[1], field[2]);
                cli.Age = Convert.ToUInt16(field[3]);
                cli.SexGenre = (EnumSexGenre)Enum.Parse(typeof(EnumSexGenre), field[4]);
                cli.Address = new ClsAddress(Convert.ToUInt16(field[5]), field[6], Convert.ToUInt16(field[7]), field[8], field[9], field[10]);
                cli.Phone = field[11];
                cli.Email = field[12];               
                cli.ClientType = (EnumClientType)Enum.Parse(typeof(EnumClientType), field[13]);
                listClient.Add(cli);
                line = sReader.ReadLine();
            }
            sReader.Close();
            return listClient;
        }

        public static ClsClient SearchById(ushort id)
        {
            ClsClient cli = new ClsClient();
            if (File.Exists(filePathClient))
            {
                StreamReader sReader = new StreamReader(filePathClient);
                string line = sReader.ReadLine();
                while (line != null)
                {
                    string[] field = line.Split('|');
                    if (Convert.ToUInt16(field[0]) == id)
                    {
                        cli.ClientId = Convert.ToUInt16(field[0]);
                        cli.Name = new ClsFullName(field[1], field[2]);
                        cli.Age = Convert.ToUInt16(field[3]);
                        cli.SexGenre = (EnumSexGenre)Enum.Parse(typeof(EnumSexGenre), field[4]);
                        cli.Address = new ClsAddress(Convert.ToUInt16(field[5]), field[6], Convert.ToUInt16(field[7]), field[8], field[9], field[10]);
                        cli.Phone = field[11];
                        cli.Email = field[12];
                        cli.ClientType = (EnumClientType)Enum.Parse(typeof(EnumClientType), field[13]);
                        sReader.Close();
                        break;
                    }
                    line = sReader.ReadLine();
                }
                sReader.Close();
            }
            return cli;
        }

        public static ClsClient SearchByEmail(string str)
        {
            ClsClient cli = new ClsClient();
            if (File.Exists(filePathClient))
            {
                StreamReader sReader = new StreamReader(filePathClient);
                string line = sReader.ReadLine();
                while (line != null)
                {
                    string[] field = line.Split('|');
                    if (field[12] == str)
                    {
                        cli.ClientId = Convert.ToUInt16(field[0]);
                        cli.Name = new ClsFullName(field[1], field[2]);
                        cli.Age = Convert.ToUInt16(field[3]);
                        cli.SexGenre = (EnumSexGenre)Enum.Parse(typeof(EnumSexGenre), field[4]);
                        cli.Address = new ClsAddress(Convert.ToUInt16(field[5]), field[6], Convert.ToUInt16(field[7]), field[8], field[9], field[10]);
                        cli.Phone = field[11];
                        cli.Email = field[12];
                        cli.ClientType = (EnumClientType)Enum.Parse(typeof(EnumClientType), field[13]);
                        sReader.Close();
                        break;
                    }
                    line = sReader.ReadLine();
                }
                sReader.Close();
            }
            return cli;
        }

        public static bool ModClient(ClsClient cli)
        {
            bool success = false;
            if (File.Exists(filePathClient))
            {
                StreamReader sReader = new StreamReader(filePathClient);
                StreamWriter sWriter = new StreamWriter(new FileStream(filePathClientMod, FileMode.Append, FileAccess.Write));

                string line = sReader.ReadLine();
                while (line != null)
                {
                    string[] field = line.Split('|');
                    if (field[0] != cli.ClientId.ToString())
                    {
                        sWriter.WriteLine(field[0] + "|" + field[1] + "|" + field[2] + "|" + field[3] + "|" + field[4] + "|" + field[5] + "|" +
                                          field[6] + "|" + field[7] + "|" + field[8] + "|" + field[9] + "|" + field[10] + "|" + field[11] + "|" + field[12] + "|" + field[13]);
                    }
                    line = sReader.ReadLine();
                }
                sWriter.WriteLine(cli.ToString());

                sReader.Close();
                File.Delete(filePathClient);
                sWriter.Close();
                File.Move(filePathClientMod, filePathClient);
            }
            return success;
        }

        public static bool DelClient(ushort id)
        {
            if (File.Exists(filePathClient))
            {
                StreamReader sReader = new StreamReader(filePathClient);
                StreamWriter sWriter = new StreamWriter(new FileStream(filePathClientMod, FileMode.Append, FileAccess.Write));

                string line = sReader.ReadLine();
                while (line != null)
                {
                    string[] field = line.Split('|');
                    if (field[0] != id.ToString())
                    {
                        sWriter.WriteLine(field[0] + "|" + field[1] + "|" + field[2] + "|" + field[3] + "|" + field[4] + "|" + field[5] + "|" +
                                          field[6] + "|" + field[7] + "|" + field[8] + "|" + field[9] + "|" + field[10] + "|" + field[11] + "|" + field[12] + "|" + field[13]);
                    }
                    line = sReader.ReadLine();
                }
                sReader.Close();
                File.Delete(filePathClient);
                sWriter.Close();
                File.Move(filePathClientMod, filePathClient);
            }
            return true;
        }
    }
}
