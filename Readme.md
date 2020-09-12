# Arithmetic Architecture Practice  

![AddImage](https://i.imgur.com/AITotbs.png)

8/25/20
Questions:  
1. Should you deserialize on backend or frontend  
2. Should API be allowed to take nulls and just return 0  
3. Should null guards be in caller or called  
4. _=> what does this underscore mean in Lambda expressions? [[Go]](https://stackoverflow.com/q/2778362/139698)  
5. Slack ReactiveUI help [[Go]](https://reactivex.slack.com/archives/C02AJB872/p1598302497043800)  
6. Understand the following
```
            this.WhenAnyValue(x => x.Input1, x => x.Input2)
                .Select(_ => Unit.Default)
                .InvokeCommand(AddNumbers);
```

7.   Figure out exception in view model
```
//AddNumbers.ThrownExceptions.Subscribe(ex => this.Log().Warn("Error!", ex));
```
8.  How do I change text background ReactiveUI way when focus?  




8/23/20  

This is a Multiple Startup Solution.  
1. Right-click on solution in Solution Explorer
2. Select Properties
3. Set Console1 and ClassLibrary1API to Start 


