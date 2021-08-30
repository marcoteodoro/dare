using System;

namespace Dare_Full_Stack.Core.Models
{
    public class ServiceResultModel<T> : ServiceResultModel where T : class
	{
		public ServiceResultModel(string friendlyErrorMessage = "") : base(friendlyErrorMessage)
		{
			Item = null;
		}

		public T Item { get; set; }
	}

	public class ServiceResultModel
	{
		public ServiceResultModel(string friendlyErrorMessage = "")
		{
			Success = false;
			FriendlyErrorMessage = friendlyErrorMessage;
			SuccessMessage = string.Empty;
			Exception = null;
		}

		public bool Success { get; set; }
		public string FriendlyErrorMessage { get; set; }
		public string SuccessMessage { get; set; }
		public Exception Exception { get; set; }
	}
}
