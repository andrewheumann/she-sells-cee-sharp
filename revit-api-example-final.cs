/*
 * Created by SharpDevelop.
 * User: andheum
 * Date: 4/27/2018
 * Time: 8:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI.Selection;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Translation.V2;

namespace macrosIntro
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    [Autodesk.Revit.DB.Macros.AddInId("9E4FC6CF-71E8-406F-BD86-D19FAD359710")]
	public partial class ThisDocument
	{
		GoogleCredential credential;
		TranslationClient client;
		private void Module_Startup(object sender, EventArgs e)
		{
			credential = GoogleCredential.FromJson(File.ReadAllText(@"C:\Users\andheum\Documents\Repos\she-sells-cee-sharp\working-docs\translation-test-c9bae2c6a8d9.json"));
			client = TranslationClient.Create(credential, TranslationModel.Base);
		}

		private void Module_Shutdown(object sender, EventArgs e)
		{

		}

		#region Revit Macros generated code
		private void InternalStartup()
		{
			this.Startup += new System.EventHandler(Module_Startup);
			this.Shutdown += new System.EventHandler(Module_Shutdown);
		}
		#endregion
		public void helloWorld()
		{
			TaskDialog.Show("Hello","Hello, World!");
		}
		public void GetAllRooms()
		{
			var fec = new FilteredElementCollector(Document);
			fec.OfCategory(BuiltInCategory.OST_Rooms);
			TaskDialog.Show("Element Count", String.Format("There are {0} rooms in the model",fec.GetElementCount()));	
			var roomNames = fec.Select(room => room.LookupParameter("Name").AsString());
			var roomNamesJoined = String.Join(", ", roomNames);
			TaskDialog.Show("Names","These are their names: " + roomNamesJoined);
			
			using(var t = new Transaction(Document)) {
				t.Start("Translate Rooms");
				foreach(var room in fec){
					var engParam = room.LookupParameter("EnglishName");
					var nameParam = room.LookupParameter("Name");
					if(string.IsNullOrEmpty(engParam.AsString())) engParam.Set(nameParam.AsString()); //prevent overwriting
					var translatedName = TranslateToLang(engParam.AsString(),"ru");
					nameParam.Set(translatedName);
				}
				t.Commit();
			}
			
		}
		
		
		
		public string TranslateToLang(string text, string langCode){
			
			var response = client.TranslateText(text, langCode);
	        return response.TranslatedText;
		}
	
		
		public string getRoomName(Autodesk.Revit.DB.Architecture.Room room){
			return room.Name;
		}
	}
}