// Generated by Haxe 3.4.7

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace register {
	public sealed class Register : global::haxe.lang.HxObject {
		
		static Register() {
			global::register.Register.instance = new global::register.Register();
		}
		
		
		public Register(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Register() {
			global::register.Register.__hx_ctor_register_Register(this);
		}
		
		
		public static void __hx_ctor_register_Register(global::register.Register __hx_this) {
		}
		
		
		public static global::register.Register instance;
		
		public global::graph.Graph _graph;
		
		public void register<T>(T clazz) {
			this.Flush();
		}
		
		
		public void Flush() {
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 366040719:
					{
						this._graph = ((global::graph.Graph) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 365482660:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "Flush", 365482660)) );
					}
					
					
					case 1352640099:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "register", 1352640099)) );
					}
					
					
					case 366040719:
					{
						return this._graph;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_invokeField(string field, int hash, global::Array dynargs) {
			unchecked {
				switch (hash) {
					case 365482660:
					{
						this.Flush();
						break;
					}
					
					
					case 1352640099:
					{
						this.register<object>(((object) (dynargs[0]) ));
						break;
					}
					
					
					default:
					{
						return base.__hx_invokeField(field, hash, dynargs);
					}
					
				}
				
				return null;
			}
		}
		
		
		public override void __hx_getFields(global::Array<object> baseArr) {
			baseArr.push("_graph");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}

