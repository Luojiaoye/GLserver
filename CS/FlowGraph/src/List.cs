// Generated by Haxe 3.4.7

#pragma warning disable 109, 114, 219, 429, 168, 162
public class List<T> : global::haxe.lang.HxObject, global::List {
	
	public List(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public List() {
		global::List<object>.__hx_ctor__List<T>(((global::List<T>) (this) ));
	}
	
	
	public static void __hx_ctor__List<T_c>(global::List<T_c> __hx_this) {
		__hx_this.length = 0;
	}
	
	
	public static object __hx_cast<T_c_c>(global::List me) {
		return ( (( me != null )) ? (me.List_cast<T_c_c>()) : default(object) );
	}
	
	
	public virtual object List_cast<T_c>() {
		if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
			return this;
		}
		
		global::List<T_c> new_me = new global::List<T_c>(global::haxe.lang.EmptyObject.EMPTY);
		global::Array<object> fields = global::Reflect.fields(this);
		int i = 0;
		while (( i < fields.length )) {
			string field = global::haxe.lang.Runtime.toString(fields[i++]);
			global::Reflect.setField(new_me, field, global::Reflect.field(this, field));
		}
		
		return new_me;
	}
	
	
	public global::_List.ListNode<T> h;
	
	public global::_List.ListNode<T> q;
	
	public int length;
	
	public virtual void @add(T item) {
		global::_List.ListNode<T> x = new global::_List.ListNode<T>(item, null);
		if (( this.h == null )) {
			this.h = x;
		}
		else {
			this.q.next = x;
		}
		
		this.q = x;
		this.length++;
	}
	
	
	public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
		unchecked {
			switch (hash) {
				case 520590566:
				{
					this.length = ((int) (@value) );
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
				case 520590566:
				{
					this.length = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
					return @value;
				}
				
				
				case 113:
				{
					this.q = ((global::_List.ListNode<T>) (global::_List.ListNode<object>.__hx_cast<T>(((global::_List.ListNode) (@value) ))) );
					return @value;
				}
				
				
				case 104:
				{
					this.h = ((global::_List.ListNode<T>) (global::_List.ListNode<object>.__hx_cast<T>(((global::_List.ListNode) (@value) ))) );
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
				case 4846113:
				{
					return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "add", 4846113)) );
				}
				
				
				case 520590566:
				{
					return this.length;
				}
				
				
				case 113:
				{
					return this.q;
				}
				
				
				case 104:
				{
					return this.h;
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
				case 520590566:
				{
					return ((double) (this.length) );
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
				case 4846113:
				{
					this.@add(global::haxe.lang.Runtime.genericCast<T>(dynargs[0]));
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
		baseArr.push("length");
		baseArr.push("q");
		baseArr.push("h");
		base.__hx_getFields(baseArr);
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
[global::haxe.lang.GenericInterface(typeof(global::List<object>))]
public interface List : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
	
	object List_cast<T_c>();
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace _List {
	public class ListNode<T> : global::haxe.lang.HxObject, global::_List.ListNode {
		
		public ListNode(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public ListNode(T item, global::_List.ListNode<T> next) {
			global::_List.ListNode<object>.__hx_ctor__List_ListNode<T>(((global::_List.ListNode<T>) (this) ), global::haxe.lang.Runtime.genericCast<T>(item), ((global::_List.ListNode<T>) (next) ));
		}
		
		
		public static void __hx_ctor__List_ListNode<T_c>(global::_List.ListNode<T_c> __hx_this, T_c item, global::_List.ListNode<T_c> next) {
			__hx_this.item = item;
			__hx_this.next = next;
		}
		
		
		public static object __hx_cast<T_c_c>(global::_List.ListNode me) {
			return ( (( me != null )) ? (me._List_ListNode_cast<T_c_c>()) : default(object) );
		}
		
		
		public virtual object _List_ListNode_cast<T_c>() {
			if (global::haxe.lang.Runtime.eq(typeof(T), typeof(T_c))) {
				return this;
			}
			
			global::_List.ListNode<T_c> new_me = new global::_List.ListNode<T_c>(global::haxe.lang.EmptyObject.EMPTY);
			global::Array<object> fields = global::Reflect.fields(this);
			int i = 0;
			while (( i < fields.length )) {
				string field = global::haxe.lang.Runtime.toString(fields[i++]);
				global::Reflect.setField(new_me, field, global::Reflect.field(this, field));
			}
			
			return new_me;
		}
		
		
		public T item;
		
		public global::_List.ListNode<T> next;
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1170195731:
					{
						this.item = global::haxe.lang.Runtime.genericCast<T>(((object) (@value) ));
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
						this.next = ((global::_List.ListNode<T>) (global::_List.ListNode<object>.__hx_cast<T>(((global::_List.ListNode) (@value) ))) );
						return @value;
					}
					
					
					case 1170195731:
					{
						this.item = global::haxe.lang.Runtime.genericCast<T>(@value);
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
					
					
					case 1170195731:
					{
						return this.item;
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
					case 1170195731:
					{
						return ((double) (global::haxe.lang.Runtime.toDouble(((object) (this.item) ))) );
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
			baseArr.push("item");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace _List {
	[global::haxe.lang.GenericInterface(typeof(global::_List.ListNode<object>))]
	public interface ListNode : global::haxe.lang.IHxObject, global::haxe.lang.IGenericObject {
		
		object _List_ListNode_cast<T_c>();
		
	}
}


