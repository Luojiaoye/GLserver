// Generated by Haxe 3.4.7

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace test {
	public class Student : global::haxe.lang.HxObject {
		
		public Student(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Student(string name, int age) {
			global::test.Student.__hx_ctor_test_Student(this, name, age);
		}
		
		
		public static void __hx_ctor_test_Student(global::test.Student __hx_this, string name, int age) {
			__hx_this._name = name;
			__hx_this._age = age;
		}
		
		
		public string _name;
		
		public int _age;
		
		public virtual string GetName() {
			return this._name;
		}
		
		
		public virtual int GetAge() {
			return this._age;
		}
		
		
		public virtual void SetAge(int age) {
			this._age = age;
		}
		
		
		public virtual void hxSerialize(global::haxe.Serializer s) {
			s.serialize(this._name);
			s.serialize(this._age);
		}
		
		
		public virtual void hxUnserialize(global::haxe.Unserializer u) {
			this._name = global::haxe.lang.Runtime.toString(u.unserialize());
			this._age = ((int) (global::haxe.lang.Runtime.toInt(u.unserialize())) );
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1058355648:
					{
						this._age = ((int) (@value) );
						return @value;
					}
					
					
					default:
					{
						return base.__hx_setField_f(field, hash, @value, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1058355648:
					{
						this._age = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
						return @value;
					}
					
					
					case 2081459754:
					{
						this._name = global::haxe.lang.Runtime.toString(@value);
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
					case 112843575:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hxUnserialize", 112843575)) );
					}
					
					
					case 336134320:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "hxSerialize", 336134320)) );
					}
					
					
					case 603321949:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "SetAge", 603321949)) );
					}
					
					
					case 1470996969:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "GetAge", 1470996969)) );
					}
					
					
					case 1758677473:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "GetName", 1758677473)) );
					}
					
					
					case 1058355648:
					{
						return this._age;
					}
					
					
					case 2081459754:
					{
						return this._name;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1058355648:
					{
						return ((double) (this._age) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override object __hx_invokeField(string field, int hash, global::Array dynargs) {
			unchecked {
				switch (hash) {
					case 112843575:
					{
						this.hxUnserialize(((global::haxe.Unserializer) (dynargs[0]) ));
						break;
					}
					
					
					case 336134320:
					{
						this.hxSerialize(((global::haxe.Serializer) (dynargs[0]) ));
						break;
					}
					
					
					case 603321949:
					{
						this.SetAge(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ));
						break;
					}
					
					
					case 1470996969:
					{
						return this.GetAge();
					}
					
					
					case 1758677473:
					{
						return this.GetName();
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
			baseArr.push("_age");
			baseArr.push("_name");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}

