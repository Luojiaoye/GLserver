// Generated by Haxe 3.4.7

#pragma warning disable 109, 114, 219, 429, 168, 162
public class StringTools : global::haxe.lang.HxObject {
	
	public StringTools(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public StringTools() {
		global::StringTools.__hx_ctor__StringTools(this);
	}
	
	
	public static void __hx_ctor__StringTools(global::StringTools __hx_this) {
	}
	
	
	public static string lpad(string s, string c, int l) {
		if (( c.Length <= 0 )) {
			return s;
		}
		
		while (( s.Length < l )) {
			s = global::haxe.lang.Runtime.concat(c, s);
		}
		
		return s;
	}
	
	
}


