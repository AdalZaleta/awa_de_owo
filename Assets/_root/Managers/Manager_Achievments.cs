using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

namespace TAAI
{
	public class Manager_Achievments : MonoBehaviour {

		string _sourcePath = "Assets\\Resources\\ChievesAll.txt";
		string _targetPath = "Assets\\Resources\\ChievesDone.txt";

		void Awake()  
		{
			Manager_Static.achievmentsManager = this;
		}

		void Achieve(int _i)
		{
			reWriteLine ("1", _i);
		}

		public void readTextFile(string file_path)
		{
			StreamReader sReader = new StreamReader(file_path);

			Debug.Log ("Reading File |");
			int current_line = 1;
			while(!sReader.EndOfStream)
			{
				string inp_ln = sReader.ReadLine( );
				if (file_path == "Assets\\Resources\\GameDeath.txt" && inp_ln == "1")
					Application.Quit ();
				if (file_path == "Assets\\Resources\\ChievesDone.txt" && inp_ln == "1")
				{
					Debug.Log ("Achievement " + current_line + "Unlocked");
				}
				current_line++;
			}
			sReader.Close ();  
		}

		public void reWriteLine(string newVal, int _iLine)
		{
			int line_to_edit = _iLine; // Warning: 1-based indexing!
			string sourceFile = _sourcePath;
			string destinationFile = _targetPath;

			// Read the appropriate line from the file.
			string lineToWrite = null;
			using (StreamReader reader = new StreamReader(sourceFile))
			{
				for (int i = 1; i <= line_to_edit; ++i)
					lineToWrite = newVal;
			}

			if (lineToWrite == null)
				Debug.Log ("ERROR");

			// Read the old file.
			string[] lines = File.ReadAllLines(destinationFile);

			// Write the new file over the old file.
			using (StreamWriter writer = new StreamWriter(destinationFile))
			{
				for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
				{
					if (currentLine == line_to_edit)
					{
						writer.WriteLine(lineToWrite);
					}
					else
					{
						writer.WriteLine(lines[currentLine - 1]);
					}
				}
			}
		}
	}
}