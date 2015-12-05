# AgileDevelopmentStudy
Agile Study Development, Priciple ,Design,Pratice 



1.Commnad Pattern
	Main class as follows :
	(1) ICommand(Execute)
	(2) Invoker(use ICommand)
	(3) Receiver(实现ICommand,每个Receiver只做具体的一件事情,如:Do,Undo,Display )
	(4) Client: Create concrete Command naming Receiver, and  set to Invoker
	Command Pattern的优点是事情的请求者和事情的执行者分离，降低耦合

2.Template Method vs Strategy
（1）Template Method : 提供执行的模板，具体操作放在子类去做，
	例如，冒泡排序,BubbleSorter,IntBubbleSorter,DoubleBubbleSorter,排序算法都是一样的（Sort）,只是部分操作不一样的(Swap,Compare)
	,这些不一样的操作放在子类去处理。
（2）Strategy 只是列出一些操作（Sort,Swap,Compare），具体操作由子类去完成
3.Facade vs Mediator
	(1) Facade: 在上层进行封装，对外提供一致的接口，具体的操作，内部去实现。
		例如：操作数据库，增删改查ProductItem,用户只需要按照接口规范，就可以与数据库交互，无需知道内部怎么操作
	(2)Mediator:在下层进行封装，与Facade。
		如：当某一输入框输入内容，自动的检索可供用户选择的关键字。Mediator将Input Item Content Changed 事件与 检索事件绑定。
		而用户完全不知晓。

4.Singleton vs Monostate
（1）Singleton:只能创建一个实例，无论在哪里，都只有该实例存在
（2）Monostate:可以创建多个实例，但是多个实例只有共享一个状态


