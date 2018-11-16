package register;
import core.node.Node;
import graph.Graph;

/**
 * 注册器
 * @author confiner
 */
@:final
class Register 
{
	private var _graph:Graph;	// 流图
	
	// 注册模板类
	public function register<T:(Node)>(clazz:T):Void
	{
		
		Flush();
	}
	
	// 刷新
	private function Flush():Void
	{
		
		
	}
	
	public static var instance(default, null):Register = new Register();
	private function new() {}
	
}