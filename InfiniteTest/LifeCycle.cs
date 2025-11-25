namespace InfiniteTest;

internal class Lifecycle
{
    [SetUp]// calls before running each test method
    public void T1()
    {
        //logic (are u admin or not)


        var res = File.AppendText("d:\\app.txt");
        res.WriteLine("Setup Method is called");
        res.Dispose();

    }

    [TearDown]// calls after running each test method
    public void T2()
    {// do logging activity

        var res = File.AppendText("d:\\app.txt");
        res.WriteLine("Teardown Method is called");
        res.Dispose();

    }

    [OneTimeSetUp]// calls before running test
    public void T3()
    {
        //database connection logic goes here
        var res = File.AppendText("d:\\app.txt");
        res.WriteLine("OnTimeSetup Method is called");
        res.Dispose();

    }

    [OneTimeTearDown]// calls after all the test is executed
    public void T4()
    {
        // close the database connection

        var res = File.AppendText("d:\\app.txt");
        res.WriteLine("Onetimeteardown Method is called");
        res.Dispose();

    }

    [Test]
    public void Add()
    {
        var res = File.AppendText("d:\\app.txt");
        res.WriteLine("Add Method is called");
        res.Dispose();
        Assert.Pass();
    }
    [Test]
    public void Divide()
    {
        var res = File.AppendText("d:\\app.txt");
        res.WriteLine("divide Method is called");
        res.Dispose();
        Assert.Pass();
    }

}

