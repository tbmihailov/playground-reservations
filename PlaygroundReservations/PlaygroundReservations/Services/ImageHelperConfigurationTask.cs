using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bootstrap.Extensions.StartupTasks;
using PlaygroundReservations.Helpers;

namespace PlaygroundReservations.Services
{
	public class ImageHelperConfigurationTask : IStartupTask
	{
		public void Run()
		{
			//Image store
			ImageHelper.ImageStore = ConfigHelper.GetAppSettingsValue("ImageStore");
			
			//Images dimensions
			ImageHelper.ThumbnailImageSize = new Size(140, 140);
			ImageHelper.DefaultImageSize = new Size(1024, 768);
	
			//Max file size in bytes
			ImageHelper.MaxFileSizeInBytes = 2097152;

			//ImageHelper supported images for upload nad save
			ImageHelper.SupportedFileTypes.Add("image/jpeg", "jpg");
			ImageHelper.SupportedFileTypes.Add("image/png", "png");
		}
		
		public void Reset()
		{
			//reset/undo statements
		}

		
	}
}