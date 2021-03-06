// Generated by Haxe 3.4.7

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace core.slot {
	public class SlotType : global::haxe.lang.Enum {
		
		public SlotType(int index) : base(index) {
		}
		
		
		public static readonly string[] __hx_constructs = new string[]{"ExecutionIn", "ExecutionOut", "DataIn", "DataOut"};
		
		public static readonly global::core.slot.SlotType ExecutionIn = new global::core.slot.SlotType(0);
		
		public static readonly global::core.slot.SlotType ExecutionOut = new global::core.slot.SlotType(1);
		
		public static readonly global::core.slot.SlotType DataIn = new global::core.slot.SlotType(2);
		
		public static readonly global::core.slot.SlotType DataOut = new global::core.slot.SlotType(3);
		
		public override string getTag() {
			return global::core.slot.SlotType.__hx_constructs[this.index];
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace core.slot {
	public class Slot : global::haxe.lang.HxObject, global::serialization.ISerializable {
		
		public Slot(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Slot() {
			global::core.slot.Slot.__hx_ctor_core_slot_Slot(this);
		}
		
		
		public static void __hx_ctor_core_slot_Slot(global::core.slot.Slot __hx_this) {
			unchecked {
				__hx_this.slotId = -1;
				__hx_this.Initialize(-1, global::core.slot.SlotType.ExecutionIn);
			}
		}
		
		
		public int slotId;
		
		public global::core.slot.SlotType slotType;
		
		public virtual void Initialize(int id, global::core.slot.SlotType type) {
			this.slotId = id;
			this.slotType = type;
		}
		
		
		public virtual bool CanConnect(global::core.slot.SlotType type) {
			if ( ! ((( ( ( ( this.slotType == global::core.slot.SlotType.DataOut ) && ( type == global::core.slot.SlotType.DataIn ) ) || ( ( this.slotType == global::core.slot.SlotType.DataIn ) && ( type == global::core.slot.SlotType.DataOut ) ) ) || ( ( this.slotType == global::core.slot.SlotType.ExecutionIn ) && ( type == global::core.slot.SlotType.ExecutionOut ) ) ))) ) {
				if (( this.slotType == global::core.slot.SlotType.ExecutionOut )) {
					return ( type == global::core.slot.SlotType.ExecutionIn );
				}
				else {
					return false;
				}
				
			}
			else {
				return true;
			}
			
		}
		
		
		public virtual bool IsData() {
			if (( this.slotType != global::core.slot.SlotType.DataIn )) {
				return ( this.slotType == global::core.slot.SlotType.DataOut );
			}
			else {
				return true;
			}
			
		}
		
		
		public virtual bool IsIn() {
			if (( this.slotType != global::core.slot.SlotType.DataIn )) {
				return ( this.slotType == global::core.slot.SlotType.ExecutionIn );
			}
			else {
				return true;
			}
			
		}
		
		
		public virtual bool IsOut() {
			if (( this.slotType != global::core.slot.SlotType.DataOut )) {
				return ( this.slotType == global::core.slot.SlotType.ExecutionOut );
			}
			else {
				return true;
			}
			
		}
		
		
		public virtual string SerializeToJson() {
			object json = new global::haxe.lang.DynamicObject(new int[]{548525016}, new object[]{this.slotType}, new int[]{1946687865}, new double[]{((double) (this.slotId) )});
			return global::haxe.format.JsonPrinter.print(json, null, null);
		}
		
		
		public virtual void SeriralizeToBytes(global::haxe.io.Bytes bytes) {
		}
		
		
		public virtual void DeserializeFromJson(string json) {
			object obj = new global::haxe.format.JsonParser(((string) (json) )).parseRec();
			this.slotId = ((int) (global::haxe.lang.Runtime.getField_f(obj, "slotId", 1946687865, true)) );
			this.slotType = ((global::core.slot.SlotType) (global::haxe.lang.Runtime.getField(obj, "slotType", 548525016, true)) );
		}
		
		
		public virtual void DeserializeFromBytes(global::haxe.io.Bytes bytes) {
		}
		
		
		public override double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			unchecked {
				switch (hash) {
					case 1946687865:
					{
						this.slotId = ((int) (@value) );
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
					case 548525016:
					{
						this.slotType = ((global::core.slot.SlotType) (@value) );
						return @value;
					}
					
					
					case 1946687865:
					{
						this.slotId = ((int) (global::haxe.lang.Runtime.toInt(@value)) );
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
					case 1885040770:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "DeserializeFromBytes", 1885040770)) );
					}
					
					
					case 337619441:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "DeserializeFromJson", 337619441)) );
					}
					
					
					case 1630734736:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "SeriralizeToBytes", 1630734736)) );
					}
					
					
					case 1990209315:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "SerializeToJson", 1990209315)) );
					}
					
					
					case 1417689764:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "IsOut", 1417689764)) );
					}
					
					
					case 815273615:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "IsIn", 815273615)) );
					}
					
					
					case 341741396:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "IsData", 341741396)) );
					}
					
					
					case 930387418:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "CanConnect", 930387418)) );
					}
					
					
					case 1668035952:
					{
						return ((global::haxe.lang.Function) (new global::haxe.lang.Closure(this, "Initialize", 1668035952)) );
					}
					
					
					case 548525016:
					{
						return this.slotType;
					}
					
					
					case 1946687865:
					{
						return this.slotId;
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
					case 1946687865:
					{
						return ((double) (this.slotId) );
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
					case 1885040770:
					{
						this.DeserializeFromBytes(((global::haxe.io.Bytes) (dynargs[0]) ));
						break;
					}
					
					
					case 337619441:
					{
						this.DeserializeFromJson(global::haxe.lang.Runtime.toString(dynargs[0]));
						break;
					}
					
					
					case 1630734736:
					{
						this.SeriralizeToBytes(((global::haxe.io.Bytes) (dynargs[0]) ));
						break;
					}
					
					
					case 1990209315:
					{
						return this.SerializeToJson();
					}
					
					
					case 1417689764:
					{
						return this.IsOut();
					}
					
					
					case 815273615:
					{
						return this.IsIn();
					}
					
					
					case 341741396:
					{
						return this.IsData();
					}
					
					
					case 930387418:
					{
						return this.CanConnect(((global::core.slot.SlotType) (dynargs[0]) ));
					}
					
					
					case 1668035952:
					{
						this.Initialize(((int) (global::haxe.lang.Runtime.toInt(dynargs[0])) ), ((global::core.slot.SlotType) (dynargs[1]) ));
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
			baseArr.push("slotType");
			baseArr.push("slotId");
			base.__hx_getFields(baseArr);
		}
		
		
	}
}


