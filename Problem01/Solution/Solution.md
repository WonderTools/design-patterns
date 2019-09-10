# Solution

This is the solution for the [problem](https://github.com/WonderTools/design-patterns/blob/master/Problem01/Assignment/ProblemStatement.md)

## Initialial Implementation

The rough uml representation of initial implementation is as shown in the image below. This is after removing the noise due to Program.

![Initial Implementation Noise Removed](Problem2.png)

In the implementation, the Speedometer depends on CarSpeedSimulator. This is okay. The speedometer should depend on some mearsuring device for measuring the speed. In this case it is a simulator. 

The Speedometer is also dependant on SpeedAlarm. This is actually not okay. Why should a speedometer depend on a SpeedAlarm to do its job. The dependency here is not in line with the business. When the speedometer is depending on SpeedAlarm, it can't be used in a system that doesn't have a speed alarm. This makes it less reusable.

It would acutally be okay for a SpeedAlarm to depend on the Speedometer. After all the SpeedAlarm needs to know the speed to trigger the alarm. While programming, we realize that we will have the control at Speedometer, and this control can be transferred to the SpeedAlarm by calling it. 

So at a design(compile) time we want SpeedAlarm to be dependent on Speedometer. At run time, we want Speedometer to be dependant on SpeedAlarm. Here we have compile dependencies opposing the direction of run time dependencies. And to achieve this we can invert the direction of dependencies using dependency inversion principle. Once we have this dependency inverted, we can add Seatbelt class in the similar way. The uml representation of the solution would be as shown below

![Solution](Solution.png)
