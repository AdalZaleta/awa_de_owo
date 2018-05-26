using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

namespace TAAI
{
	public class HandleTextFile : MonoBehaviour {

		string _sourcePath = "Assets\\Resources\\test.txt";
		string _targetPath = "Assets\\Resources\\GameDeath.txt";

		void Start () {
			if (gameObject.CompareTag("Hitman"))
			{
				reWriteLine ("1", 1);
			}
			readTextFile (_targetPath);
		}

		public void readTextFile(string file_path)
		{
			StreamReader sReader = new StreamReader(file_path);

			Debug.Log ("Reading File |");
			while(!sReader.EndOfStream)
			{
				string inp_ln = sReader.ReadLine( );
				if (file_path == "Assets\\Resources\\GameDeath.txt" && inp_ln == "1")
					Application.Quit ();
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