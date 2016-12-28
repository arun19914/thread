using System.Threading;
using System;

class Myclass
{
	Object o=new Object();
	public void execute()
	{
	  lock(o)
	{		
		for(int i=0;i<5;i++)
		{
			System.Console.WriteLine(i+"thread1");
			Thread.Sleep(1000);
		}
	}	
	}
	public void execute2()
	{
		for(int i=5;i<10;i++)
		{
			System.Console.WriteLine(i+"thread2");
			Thread.Sleep(1000);
		}	
	}
}

class prog
{
	public static void Main()
	{
		Myclass mc=new Myclass();
		Thread t1=new Thread(new ThreadStart(mc.execute));
		Thread t2=new Thread(new ThreadStart(mc.execute));
		t1.Start();	
		t2.Start();
		t1.Join();
		t2.Join();
		for(int i=10;i<15;i++)
		{
			System.Console.WriteLine(i+"main");
			Thread.Sleep(500);
		}	
	}
}
