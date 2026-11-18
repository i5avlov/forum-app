# Forum App
ASP.NET Core Forum App 

## Overview 
An ASP.NET Core web app intended to work like Reddit maybe - a number of discussions over various topics placed in categories and subcategories. 

Users can 
- browse and view discussions 
- register and log in 
    - view and change account 
    - participate in discussions with comments 
        - possibly assessing other participants' comments 
    - open discussions  
    - give up or down-votes to other users' comments. 

## Database 

### Application User 
Id | FirstName | LastName | Country | City | Birthdate | Posts
### Discussion 
Id | Topic | Category | Posts 
### Post 
Id | Title | Text | DiscussionId | UserId 
### Category 
Id | Name | ParentCategoryId | Discussions 
### Vote 
Id | UserId | PostId | IsPositive 
