# Desktop application with Real-Time Multi-Form Data Synchronization

## The Context
You are working on a desktop application that consists of multiple forms. 
Those forms show different views of the same data and they should update in real time. 
Your application is extensible, and third parties can add plug-ins that contain their own views of the data.

## The Problem
 Should you use delegates or events to provide Real-Time Data Synchronization?

 This becomes particularly important when your application is extensible and third-party 
 developers can create plugins with their own custom views of the data.

 ## The Solution: Events
 
 | Aspect    | Delegates | Events |
| -------- | ------- | ------- |
| Encapsulation  | Weaker - subscribers can invoke the delegate   | Stronger - only the declaring class can invoke |
| Safety | $80     | Less safe - subscribers can override invocation list | Safer - controlled add/remove semantics|
| Plugin Support    | Possible but riskier    | Excellent - clear public contract |
| Memory Management    | Manual unsubscribe required    | Built-in unsubscribe pattern |
| Design Guidelines    | Not recommended for cross-class communication   | Standard .NET pattern |

 ## Architecture / Core Components
![Architecture](RealTimeWinFormsApp/Assets/flow-arch.png).
