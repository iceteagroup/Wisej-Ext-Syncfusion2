using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Web;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Test.Component
{
	public partial class FileManager : TestBase
	{
		private string baseDirectory = Application.StartupPath;

		public FileManager()
		{
			InitializeComponent();
		}

		private void FileManager_Load(object sender, EventArgs e)
		{
			var baseUrl = this.fileManager1.GetPostbackURL();
			this.fileManager1.Options = new
			{
				ajaxSettings = new {
					url = baseUrl + "&perform=FileOperations",
					getImageUrl = baseUrl + "&perform=GetImage",
					uploadUrl = baseUrl + "&perform=Upload",
					downloadUrl = baseUrl + "&perform=Download"
				},
				view = "LargeIcons"
			};
		}

		private void fileManager1_WebRequest(object sender, WebRequestEventArgs e)
		{
			object arguments = null;
			using (var sr = new StreamReader(e.Request.InputStream))
			{
				arguments = JSON.Parse(sr.ReadToEnd());
			}

			switch (e.Request.Params["perform"])
			{
				case "FileOperations":
					ProcessFileOperations(e.Response, arguments);
					break;

				case "GetImage":
					break;

				case "Upload":
					ProcessUploadOperation(e.Request);
					break;

				case "Download":
					ProcessDownloadOperation(e.Request, e.Response);
					break;

				default:
					break;
			}
		}

		private void ProcessDownloadOperation(HttpRequest request, HttpResponse response)
		{
			var args = JSON.Parse(request.Form[0]);

			switch (args.action)
			{
				case "download":
					DownloadFiles(args.data);
					response.StatusCode = (int)HttpStatusCode.NoContent;
					break;
			}
		}

		private void DownloadFiles(dynamic[] data)
		{
			foreach (var fileData in data)
			{
				Application.Download(fileData.path);
			}
		}

		private void ProcessUploadOperation(HttpRequest request)
		{
			var path = request.Form["path"];
			var data = request.Form["data"];
			var action = request.Form["action"];

			switch (action) 
			{
				case "save":
					SaveFiles(path, request.Files);
					break;
			}
		}

		private void SaveFiles(string path, HttpFileCollection files)
		{
			var appPath = Application.MapPath(path);
			foreach (string fileKey in files)
			{
				var file = files[fileKey];
				file.SaveAs($"{appPath}/{file.FileName}");
			}
		}

		private void ProcessFileOperations(HttpResponse response, dynamic data)
		{

			using (var streamWriter = new StreamWriter(response.OutputStream))
			{
				var path = data["path"];
				var action = data["action"];
				var innerData = data["data"];
				var showHiddenItems = data["showHiddenItems"];

				switch (action)
				{
					case "read":
						response.Write(ReadFiles(path));
						break;

				}
			}
		}

		private string ReadFiles(string path)
		{
			// get parameters.
			var appPath = Application.MapPath(path);
			var directory = new DirectoryInfo(appPath);
			var filesInfo = directory.GetFileSystemInfos();

			return GetFilesJson(directory, filesInfo, path);
		}

		private string UploadFile()
		{
			return "";
		}

		private string GetFilesJson(DirectoryInfo directory, FileSystemInfo[] files, string path)
		{
			var myFiles = new List<object>();

			// record file info.
			foreach (var file in files)
			{
				FileInfo fileInfo = null;
				if ((file.Attributes & FileAttributes.Directory) != FileAttributes.Directory)
					fileInfo = new FileInfo(file.FullName);

				myFiles.Add(new
				{
					name = file.Name,
					filterPath = path,
					path = file.FullName,
					dateCreated = file.CreationTime,
					dateModified = file.LastWriteTime,
					size = fileInfo != null ? fileInfo.Length : 0,
					type = (fileInfo != null) ? fileInfo.Extension : "",
					isFile = ((file.Attributes & FileAttributes.Directory) != FileAttributes.Directory)
				});
			}

			// generate response.
			var response = new
			{
				cwd = new
				{
					isFile = false,
					filterPath = path,
					Name = directory.Name,
					showHiddenItems = false,
					hasChild = files.Length > 0,
				},
				files = myFiles
			};

			return JSON.Stringify(response);
		}
	}
}
