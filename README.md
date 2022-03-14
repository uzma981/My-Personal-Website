# My Personal Website

- C# ASP.Net MVC
- Database: Microsoft SQL Server.
- Quickly designed and customized the responsive site with Bootstrap.
- Brief summary of each sections of the application 👇


## 📝 To do List: 
- Database driven To do List using ASP.net
- I tend to use lists to prioritize my workload and set clear targets for myself to achieve at the end of the day. Deciding between a timetable and a to do list is always a challenge, but personally for me a to do list takes the lead. I prefer having a tick list where I can see my tasks to be completed slowly disappearing as I scribble my way through them (the good old days) . Therefore, I wanted to apply the same concept in my personal website to use on a daily basis.

1. ApplicationDbContext class which handles the task of connecting to the default localdb database and mapping TodoCategory objectis to the database records.
2. A new AddTodoController class -  code that retrieves the to do list data and displays it in the browser using a view template. A request to the AddTodo controller returns all the entries in the To do table and then passes the results to the Index view.
3. Index.cshtml file - used @model directive to allow access to the list of to do's that the controller passed to the view using a Model object and displayed it.
4. Create/Delete/Edit.cshtml files in the Views folder with corresponding IActionResult methods for each element. Each method has its unique function e.g. IActionResult Create() passes in Todo class as obj, goes through checks to see if the user has inputted the correct format of a to do list. If it passes through, the 'to do' created by the user will successfully add to the database.


![image](https://user-images.githubusercontent.com/80789801/158245253-8603d6d7-19af-4d14-89a6-165bb919232d.png)

## 💰 Expense Tracker
- Modified the to do list process/code to develop the expense tracker - similar code.

![image](https://user-images.githubusercontent.com/80789801/158254664-ad2bcaff-d19f-4daa-a637-a922d0442234.png)

## 👜 Wish List


- This website is still in the making..
