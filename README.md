# 08_Method_Override
### In **Base Class** we have a method, but we want to make some changes in **Derived Class**

Thus, it need to be a *vitual* method  in **Base Class**. By specify a word `vitual` after method type `public`.


```
public vitual string Sound()
{
    return "Meow";
}
```

### In **Derived Class** we create the same method, like the one in **Base Class**.

Thus, it need to be a *override* method  in **Derived Class**. By specify a word `override` after method type `public`.


```
public override string Sound()
{
    return "Wohh";
}
```
