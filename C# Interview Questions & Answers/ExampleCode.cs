// Question 8

/* using (MyResource abc = new MyResource())
{
 abc.program();
}
Gets translated to,
MyResource abc= new MyResource();
try
{
 myRes.program();
}
finally
{
 // Check for a null resource.
 if (abc!= null)
     // Call the object's Dispose method.
     ((IDisposable)abc).Dispose();
} */



