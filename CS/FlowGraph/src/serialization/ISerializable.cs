// Generated by Haxe 3.4.7

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace serialization {
	public interface ISerializable : global::haxe.lang.IHxObject {
		
		string SerializeToJson();
		
		void SeriralizeToBytes(global::haxe.io.Bytes bytes);
		
		void DeserializeFromJson(string json);
		
		void DeserializeFromBytes(global::haxe.io.Bytes bytes);
		
	}
}


