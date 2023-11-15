package crc64f91024f8726adbe6;


public class PancakeViewRenderer
	extends crc64e1fb321c08285b90.VisualElementRenderer_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onDraw:(Landroid/graphics/Canvas;)V:GetOnDraw_Landroid_graphics_Canvas_Handler\n" +
			"n_drawChild:(Landroid/graphics/Canvas;Landroid/view/View;J)Z:GetDrawChild_Landroid_graphics_Canvas_Landroid_view_View_JHandler\n" +
			"";
		mono.android.Runtime.register ("Maui.PancakeView.Droid.PancakeViewRenderer, PancakeViewCompat", PancakeViewRenderer.class, __md_methods);
	}


	public PancakeViewRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == PancakeViewRenderer.class) {
			mono.android.TypeManager.Activate ("Maui.PancakeView.Droid.PancakeViewRenderer, PancakeViewCompat", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}


	public PancakeViewRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == PancakeViewRenderer.class) {
			mono.android.TypeManager.Activate ("Maui.PancakeView.Droid.PancakeViewRenderer, PancakeViewCompat", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
		}
	}


	public PancakeViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == PancakeViewRenderer.class) {
			mono.android.TypeManager.Activate ("Maui.PancakeView.Droid.PancakeViewRenderer, PancakeViewCompat", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, System.Private.CoreLib", this, new java.lang.Object[] { p0, p1, p2 });
		}
	}


	public PancakeViewRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == PancakeViewRenderer.class) {
			mono.android.TypeManager.Activate ("Maui.PancakeView.Droid.PancakeViewRenderer, PancakeViewCompat", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, System.Private.CoreLib:System.Int32, System.Private.CoreLib", this, new java.lang.Object[] { p0, p1, p2, p3 });
		}
	}


	public void onDraw (android.graphics.Canvas p0)
	{
		n_onDraw (p0);
	}

	private native void n_onDraw (android.graphics.Canvas p0);


	public boolean drawChild (android.graphics.Canvas p0, android.view.View p1, long p2)
	{
		return n_drawChild (p0, p1, p2);
	}

	private native boolean n_drawChild (android.graphics.Canvas p0, android.view.View p1, long p2);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
