// Generated by Haxe 3.4.7

#pragma warning disable 109, 114, 219, 429, 168, 162
public class Entry : global::haxe.lang.HxObject {
	
	public Entry(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public Entry() {
		global::Entry.__hx_ctor__Entry(this);
	}
	
	
	public static void __hx_ctor__Entry(global::Entry __hx_this) {
	}
	
	
	public static void main() {
		unchecked {
			global::core.slot.Slot dataSlotIn = new global::core.slot.Slot();
			dataSlotIn.Initialize(1, global::core.slot.SlotType.DataIn);
			global::core.slot.Slot actionSlotIn = new global::core.slot.Slot();
			actionSlotIn.Initialize(2, global::core.slot.SlotType.ExecutionIn);
			global::core.slot.Slot dataSlotOut = new global::core.slot.Slot();
			dataSlotOut.Initialize(3, global::core.slot.SlotType.DataOut);
			global::core.slot.Slot actionSlotOut = new global::core.slot.Slot();
			actionSlotOut.Initialize(4, global::core.slot.SlotType.ExecutionOut);
			global::core.node.Node actionNode = new global::core.node.Node();
			actionNode.Initialize(new global::haxe.lang.Null<int>(1, true), "First Node", "Action Node");
			actionNode.AddSlot(actionSlotOut);
			actionNode.AddSlot(dataSlotIn);
			actionNode.AddSlot(actionSlotIn);
			global::core.node.Node dataNode = new global::core.node.Node();
			dataNode.Initialize(new global::haxe.lang.Null<int>(2, true), "Second Node", "Data Node");
			dataNode.AddSlot(dataSlotOut);
			global::core.node.Node node3 = new global::core.node.Node();
			node3.Initialize(new global::haxe.lang.Null<int>(3, true), "Third Node", "Action Node");
			node3.AddSlot(dataSlotIn);
			node3.AddSlot(actionSlotOut);
			node3.AddSlot(actionSlotIn);
			global::core.node.Node node4 = new global::core.node.Node();
			node4.Initialize(new global::haxe.lang.Null<int>(4, true), "Forth Node", "Action Node");
			node4.AddSlot(actionSlotIn);
			global::graph.Graph graph1 = new global::graph.Graph(((string) ("testGraphData") ));
			graph1.AddNode(actionNode);
			graph1.AddNode(dataNode);
			graph1.AddNode(node3);
			graph1.AddNode(node4);
			global::graph.EndPoint ep1 = new global::graph.EndPoint(new global::haxe.lang.Null<int>(actionNode.nodeId, true), new global::haxe.lang.Null<int>(actionSlotOut.slotId, true));
			global::graph.EndPoint ep2 = new global::graph.EndPoint(new global::haxe.lang.Null<int>(dataNode.nodeId, true), new global::haxe.lang.Null<int>(dataSlotOut.slotId, true));
			global::graph.EndPoint ep3 = new global::graph.EndPoint(new global::haxe.lang.Null<int>(node3.nodeId, true), new global::haxe.lang.Null<int>(actionSlotIn.slotId, true));
			global::graph.EndPoint ep4 = new global::graph.EndPoint(new global::haxe.lang.Null<int>(node3.nodeId, true), new global::haxe.lang.Null<int>(dataSlotIn.slotId, true));
			global::graph.EndPoint ep5 = new global::graph.EndPoint(new global::haxe.lang.Null<int>(node3.nodeId, true), new global::haxe.lang.Null<int>(actionSlotOut.slotId, true));
			global::graph.EndPoint ep6 = new global::graph.EndPoint(new global::haxe.lang.Null<int>(node4.nodeId, true), new global::haxe.lang.Null<int>(actionSlotIn.slotId, true));
			graph1.AddRelation(ep1, new global::Array<object>(new object[]{ep3}));
			graph1.AddRelation(ep2, new global::Array<object>(new object[]{ep4}));
			graph1.AddRelation(ep5, new global::Array<object>(new object[]{ep6}));
			string str = graph1.SerializeToJson();
			global::haxe.Log.trace.__hx_invoke2_o(default(double), str, default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "Entry", "Entry.hx"}, new int[]{1981972957}, new double[]{((double) (151) )}));
		}
	}
	
	
	public static void changeString(global::test.Student stu) {
		unchecked {
			stu.SetAge(1000);
		}
	}
	
	
}


