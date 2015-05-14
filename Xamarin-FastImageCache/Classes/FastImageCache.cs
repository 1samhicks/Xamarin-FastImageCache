using System;
using System.Reflection;
using UIKit;
using Foundation;
using System.Collections.Generic;

namespace XamarinFastImageCache
{
	public class FastImageCache
	{
		static FastImageCache fastImageCache = null;
		/*
		 * Enforce singleton-ness of class.
		 * */
		private FastImageCache ()
		{
			if (fastImageCache == null)
				fastImageCache = new FastImageCache();
		}

		/*
		public FastImageCache(string nameSpace) {
			FastImageCache fastImageCache = new FastImageCache ();


		}*/

		public static FastImageCache SharedImageCache() {
			if(fastImageCache == null) 
				fastImageCache = new FastImageCache();
			return fastImageCache;
			
		}


		public static NSOperationQueue DispatchQueue() {
			throw new NotImplementedException ("{0} is not implemented" + System.Reflection.MethodBase.GetCurrentMethod().Name);
		}

		public void SetFormats(List<FICImageFormat> fimcObjects) {
			throw new NotImplementedException ("{0} is not implemented" + System.Reflection.MethodBase.GetCurrentMethod().Name);
		}

		public List<FICImageFormat> FormatsWithFamily(string family) {
			throw new NotImplementedException ("{0} is not implemented" + System.Reflection.MethodBase.GetCurrentMethod().Name);
		}

	}
}

