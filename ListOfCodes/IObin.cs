using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic; //to use : the generic class List<>
using System.Windows.Forms; //to use:  Form,  MessageBox,  OpenFileDialog  classes
using System.Xml.Serialization;

namespace ListOfCodes : IFileIO
{
    
    //in the form...
    	private List<Person> listOfPersons;

		private void Form1_Load(object sender, EventArgs e)
		{
			listOfPersons = new List<Person>();
		}
    
     //in the form...
    private void btnAdd_Click(object sender, EventArgs e) 
		{   
			if (txtID.TextLength == 0)
			{
				MessageBox.Show("Please enter the ID.");
				return;
			}
			else if (txtName.TextLength == 0)
			{
				MessageBox.Show("Please enter the Name.");
				return;
			}
            Person p = new Person(txtID.Text, txtName.Text);
            listOfPersons.Add(p);
            lstPerson.Items.Add(p);

			txtID.Clear();
			txtName.Clear();
		}

 //in the form...
		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (lstPerson.SelectedIndex > -1)
			{
				Person p = (Person)lstPerson.SelectedItem;
				lstPerson.Items.Remove(p);
				listOfPersons.Remove(p);
			}
		}

 //in the form...
		private void lstPerson_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstPerson.SelectedIndex > -1)
			{
				btnDelete.Enabled = true;
			}
			else
			{
				btnDelete.Enabled = false;
			}
		}
    
    
 /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////   
    
    //BIN
    class IObin
    {
        private string fileName;

		public BinFileIO(string file)
		{
			fileName = file;
		}

		public void SaveToFile(List<Person> list)
		{
			using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
			{
				using (BinaryWriter writer = new BinaryWriter(fs, Encoding.GetEncoding("utf-8")))
				{
					foreach (Person p in list)
					{
						writer.Write(p.Id);
						writer.Write(p.Name);
					}
				}
			}
		}

		public List<Person> LoadFromFile()
		{
		  List<Person> list = new List<Person>();

			using (FileStream fs = File.OpenRead(fileName))
			{
				using (BinaryReader reader = new BinaryReader(fs, Encoding.GetEncoding("utf-8")))
				{
					while (reader.PeekChar() != -1)
					{
						list.Add(new Person(reader.ReadString(), reader.ReadString()));
					}
				}
			}
		  return list;
		}

        //in the form...
        private void btnBinLoad_Click(object sender, EventArgs e){
            OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Binary Files (*.bin)|*.bin";
            //The filter string must contains the description of the filter (Binary Files (*.bin)
            //followed by the vertical (|) bar and the filter pattern (*.bin ).        

			if (ofd.ShowDialog() == DialogResult.OK)
			{               
                IFileIO file = new BinFileIO(ofd.FileName);  

				try
				{
					listOfPersons = file.LoadFromFile();

					lstPerson.BeginUpdate();
					foreach (Person p in listOfPersons)
					{
						lstPerson.Items.Add(p);
					}
					lstPerson.EndUpdate();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

        //in the form...
		private void btnBinSave_Click(object sender, EventArgs e){
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Binary Files (*.bin)|*.bin";
            //The filter string must contains the description of the filter (Binary Files (*.bin)
            //followed by the vertical (|) bar and the filter pattern (*.bin ).
            

			if (sfd.ShowDialog() == DialogResult.OK)
			{
                IFileIO file = new BinFileIO(sfd.FileName);          

				try
				{
					file.SaveToFile(listOfPersons);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

         /// <summary>
        ///Second way to save to binary file and to load from binary file 
        /// </summary>
        
        private string fileName;
        
        //get serializer
        IFormatter serializer = new BinaryFormatter();

        public BinFileIOV2(string file)
        {
            fileName = file;
        }

        public void SaveToFile(List<Person> list)
        {
            //serialize the list
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            serializer.Serialize(fs, list);
            fs.Close();
        }
       
        public List<Person> LoadFromFile()
        {
            //deserialize the list
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            List<Person> list = serializer.Deserialize(fs) as List<Person>;
            fs.Close();
            return list;
        }


        //in the form...
       private void buttonBinLoadV2_Click(object sender, EventArgs e){
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Binary Files (*.bin)|*.bin";
            //The filter string must contains the description of the filter (Binary Files (*.bin)
            //followed by the vertical (|) bar and the filter pattern (*.bin ).            

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                IFileIO file = new BinFileIOV2(ofd.FileName);  //CHANGING FROM BinFileIO TO BinFileIOV2

                try
                {
                    listOfPersons = file.LoadFromFile();

                    lstPerson.BeginUpdate();
                    foreach (Person p in listOfPersons)
                    {
                        lstPerson.Items.Add(p);
                    }
                    lstPerson.EndUpdate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //in the form...
        private void buttonBinSaveV2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Binary Files (*.bin)|*.bin";
            //The filter string must contains the description of the filter (Binary Files (*.bin)
            //followed by the vertical (|) bar and the filter pattern (*.bin ).
            

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                IFileIO file = new BinFileIOV2(sfd.FileName); //CHANGING FROM BinFileIO TO BinFileIOV2

                try
                {
                    file.SaveToFile(listOfPersons);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



    }
}


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//for the Interface IFileIO
namespace CSharpFileIO
{
	interface IFileIO
	{
		void SaveToFile(List<Person> list);

		List<Person> LoadFromFile();

	} // End of interface FileIO
}


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


// for txt file encapsulated in a class
namespace CSharpFileIO
{   
    class TxtFileIO : IFileIO
	{
		private string fileName;

		public TxtFileIO(string file)
		{
			fileName = file;
		}

		public void SaveToFile(List<Person> list)
		{
			using (StreamWriter writer = File.CreateText(fileName + ".tmp"))
			{
				foreach (Person p in list)
				{
					writer.WriteLine(p.Id + "," + p.Name);
				}
			}
		  File.Copy(fileName + ".tmp", fileName, true);
			// If the writing is done successfully, copy the temp file to overwrite the original file.

		  File.Delete(fileName + ".tmp");
			// If the copying is done successfully, delete the temp file.
		}

		public List<Person> LoadFromFile()
		{
			List<Person> list = new List<Person>();

			using (StreamReader reader = File.OpenText(fileName))
			{
				while (!reader.EndOfStream)
				{
					string[] array = reader.ReadLine().Split(',');

					list.Add(new Person(array[0], array[1]));
				}
			}
		  return list;
		}

	} 
}


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//for CSV file....
namespace CSharpFileIO
{
	class CsvFileIO : IFileIO
	{
		private string fileName;

        public CsvFileIO(string file)
		{
			fileName = file;
		}

		public void SaveToFile(List<Person> list)
		{
			using (StreamWriter writer = File.CreateText(fileName + ".tmp"))
			{
				foreach (Person p in list)
				{
					writer.WriteLine(p.Id + "," + p.Name);
				}
			}

		File.Copy(fileName + ".tmp", fileName, true);
			// If the writing is done successfully, copy the temp file to overwrite the original file.

		File.Delete(fileName + ".tmp");
			// If the copying is done successfully, delete the temp file.
		}

		public List<Person> LoadFromFile()
		{
			List<Person> list = new List<Person>();

			using (StreamReader reader = File.OpenText(fileName))
			{
				while (!reader.EndOfStream)
				{
					string[] array = reader.ReadLine().Split(',');

					list.Add(new Person(array[0], array[1]));
				}
			}

		  return list;
		}

	} // End of class CsvFileIO

    //in the form...
    private void btnCsvLoad_Click(object sender, EventArgs e){
              OpenFileDialog ofd = new OpenFileDialog(); 
                                              
          ofd.Filter = "TXT Files (*.txt)|*.txt| CSV Files (*.csv)|*.csv";
       //The filter string must contains the description of the filter ( TXT Files (*.txt)  OR  CSV Files (*.csv))
       //followed by the vertical (|) bar and the filter pattern (  *.txt  OR *.csv ).
          //ofd.Filter = "CSV Files (*.csv)|*.csv"; 

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				IFileIO file = new TxtFileIO(ofd.FileName);

				try
				{
					listOfPersons = file.LoadFromFile();

				lstPerson.BeginUpdate();
					foreach (Person p in listOfPersons)
					{
						lstPerson.Items.Add(p);
					}
				lstPerson.EndUpdate();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
        
//in the form...
		private void btnCsvSave_Click(object sender, EventArgs e){
			SaveFileDialog sfd = new SaveFileDialog();
			     ///sfd.Filter = "CSV Files (*.csv)|*.csv";           
            sfd.Filter = "TXT Files (*.txt)|*.txt| CSV Files (*.csv)|*.csv";
            //The filter string must contains the description of the filter ( TXT Files (*.txt)  OR  CSV Files (*.csv))
            //followed by the vertical (|) bar and the filter pattern (  *.txt  OR *.csv ).
            //ofd.Filter = "CSV Files (*.csv)|*.csv"; 


			if (sfd.ShowDialog() == DialogResult.OK){
				IFileIO file = new TxtFileIO(sfd.FileName);

				try{
					file.SaveToFile(listOfPersons);
				}
				catch (Exception ex){
					MessageBox.Show(ex.Message);
				}
			}
		}
}


 /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////   


//XML
class XmlFileIO : IFileIO
	{
		private string fileName;

		public XmlFileIO(string n)
		{
			fileName = n;
		}

		public void SaveToFile(List<Person> list)
		{
			XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

			using (StreamWriter writer = File.CreateText(fileName + ".tmp"))
			{
				serializer.Serialize(writer, list);
			}

			File.Copy(fileName + ".tmp", fileName, true);
			File.Delete(fileName + ".tmp");
		}

		public List<Person> LoadFromFile()
		{
			List<Person> list = new List<Person>();
			XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

			using (StreamReader reader = File.OpenText(fileName))
			{
				list = (List<Person>)serializer.Deserialize(reader);
			}

			return list;
		}

	} // End of class XmlFileIO
}

//in the form...
    private void btnXmlLoad_Click(object sender, EventArgs e){

            		listOfPerson.Clear();
            		OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "XML Files (*.xml)|*.xml";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				IFileIO file = new XmlFileIO(ofd.FileName);

				try
				{
					listOfPerson = file.LoadFromFile();

					lstPerson.BeginUpdate();
					foreach (Person p in listOfPerson)
					{
						lstPerson.Items.Add(p);
					}
					lstPerson.EndUpdate();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
//in the form...
		private void btnXmlSave_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "XML Files (*.xml)|*.xml";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				IFileIO file = new XmlFileIO(sfd.FileName);

				try
				{
					file.SaveToFile(listOfPerson);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}