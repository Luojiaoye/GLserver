// Generated by Haxe 3.4.7

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	public class GenericCell<T> : global::haxe.lang.HxObject, global::haxe.ds.GenericCell {
		
		public GenericCell(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public GenericCell(T elt, global::haxe.ds.GenericCell<T> next) {
			global::haxe.ds.GenericCell<object>.__hx_ctor_haxe_ds_GenericCell<T>(((global::haxe.ds.GenericCell<T>) (this) ), global::haxe.lang.Runtime.genericCast<T>(elt), ((global::haxe.ds.GenericCell<T>) (next) ));
		}
		
		
		public static void __hx_ctor_haxe_ds_GenericCell<T_c>(global::haxe.ds.GenericCell<T_c> __hx_this, T_c elt, global::haxe.ds.GenericCell<T_c> next) {
			__hx_this.elt = elt;
			__hx_this.next = next;
		}
		
		
		public static object __hx_cast<T_c_c>(global::haxe.ds.GenericCell me) {
			return ( (( me != null )) ? (me.haxe_ds_GenericCell_cast<T_c_c>()) : default(object) );
		}
		
		
		public virtual object haxe_ds_GenericCell_cast<T_c>() {
			if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
				return this;
			}
			
			global::haxe.ds.GenericCell<T_c> new_me = new global::haxe.ds.GenericCell<T_c>(global::haxe.lang.EmptyObject.EMPTY);
			global::Array<object> fields = global::Reflect.fields(this);
			int i = 0;
			while (( i < fields.length )) {
				string field = global::haxe.lang.Runtime.toString(fields[i++]);
				global::Reflect.setField(new_me, field, global::Reflect.field(this, field));
			}
			
			return new_me;
		}
		
		
		public T elt;
		
		public global::haxe.ds.GenericCell<T> next;
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 5046829:
					{
						this.elt = global::haxe.lang.Runtime.genericCast<T>(((object) (@value) ));
						return ((double) (global::haxe.lang.Runtime.toDouble(((object) (@value) ))) );
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
					case 1224901875:
					{
						this.next = ((global::haxe.ds.GenericCell<T>) (global::haxe.ds.GenericCell<object>.__hx_cast<T>(((global::haxe.ds.GenericCell) (@value) ))) );
						return @value;
					}
					
					
					case 5046829:
					{
						this.elt = global::haxe.lang.Runtime.genericCast<T>(@value);
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
					case 1224901875:
					{
						return this.next;
					}
					
					
					case 5046829:
					{
						return this.elt;
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
					case 5046829:
					{
						return ((double) (global::haxe.lang.Runtime.toDouble(((object) (this.elt) ))) );
					}
					
					
					default:
					{
						return base.__hx_getField_f(field, hash, throwErrors, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::Array<object> baseArr) {
			baseArr.push("next");
			baseArr.push("elt");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	[global::haxe.lang.GenericInterface(typeof(global::haxe.ds.GenericCell<object>))]
	public interface GenericCell : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		
		object haxe_ds_GenericCell_cast<T_c>();
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	public class GenericStack<T> : global::haxe.lang.HxObject, global::haxe.ds.GenericStack {
		
		public GenericStack(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public GenericStack() {
			global::haxe.ds.GenericStack<object>.__hx_ctor_haxe_ds_GenericStack<T>(((global::haxe.ds.GenericStack<T>) (this) ));
		}
		
		
		public static void __hx_ctor_haxe_ds_GenericStack<T_c>(global::haxe.ds.GenericStack<T_c> __hx_this) {
		}
		
		
		public static object __hx_cast<T_c_c>(global::haxe.ds.GenericStack me) {
			return ( (( me != null )) ? (me.haxe_ds_GenericStack_cast<T_c_c>()) : default(object) );
		}
		
		
		public virtual object haxe_ds_GenericStack_cast<T_c>() {
			if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
				return this;
			}
			
			global::haxe.ds.GenericStack<T_c> new_me = new global::haxe.ds.GenericStack<T_c>(global::haxe.lang.EmptyObject.EMPTY);
			global::Array<object> fields = global::Reflect.fields(this);
			int i = 0;
			while (( i < fields.length )) {
				string field = global::haxe.lang.Runtime.toString(fields[i++]);
				global::Reflect.setField(new_me, field, global::Reflect.field(this, field));
			}
			
			return new_me;
		}
		
		
		public global::haxe.ds.GenericCell<T> head;
		
		public override object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1158359328:
					{
						this.head = ((global::haxe.ds.GenericCell<T>) (global::haxe.ds.GenericCell<object>.__hx_cast<T>(((global::haxe.ds.GenericCell) (@value) ))) );
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
					case 1158359328:
					{
						return this.head;
					}
					
					
					default:
					{
						return base.__hx_getField(field, hash, throwErrors, isCheck, handleProperties);
					}
					
				}
				
			}
		}
		
		
		public override void __hx_getFields(global::Array<object> baseArr) {
			baseArr.push("head");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.ds {
	[global::haxe.lang.GenericInterface(typeof(global::haxe.ds.GenericStack<object>))]
	public interface GenericStack : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		
		object haxe_ds_GenericStack_cast<T_c>();
		
	}
}


