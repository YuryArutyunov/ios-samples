// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace HandlingRotation.Screens.iPad.Method1Autosize {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[Foundation.Register("AutosizeScreenPad")]
	public partial class AutosizeScreenPad {
		
		private UIKit.UIView __mt_view;
		
		private UIKit.UITableView __mt_tblMain;
		
		#pragma warning disable 0169
		[Foundation.Connect("view")]
		private UIKit.UIView view {
			get {
				this.__mt_view = ((UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[Foundation.Connect("tblMain")]
		private UIKit.UITableView tblMain {
			get {
				this.__mt_tblMain = ((UIKit.UITableView)(this.GetNativeField("tblMain")));
				return this.__mt_tblMain;
			}
			set {
				this.__mt_tblMain = value;
				this.SetNativeField("tblMain", value);
			}
		}
	}
}
