using Android.App;
using Android.Runtime;
using Android.Views;

namespace Exam_Score_Pridicter;

[Application]
public class MainApplication : MauiApplication
{
	public MainApplication(IntPtr handle, JniHandleOwnership ownership)
		: base(handle, ownership)
	{

	}
    

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
