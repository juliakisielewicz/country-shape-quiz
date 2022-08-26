# Country Shape Quiz

Web application based on ASP.NET Core Razor Pages. Authentication and authorization based on ASP.NET Core Identity using roles.

As a logged-in user, you can play a game about recognizing countries by their shapes. You can also view the results of a recently completed game. When logged in as Administrator, you can additionally manage the list of countries - view and edit details, delete a country and create a new one. 

The list of countries as well as users and roles data are stored in local database.

## Technologies

* ASP.NET Core Razor Pages
* ASP.NET Core Identity
* Entity Framework
* C#, HTML, CSS + Bootstrap



## Preview

After logging in, the following Home Page appears. 
If the user is not logged in, a similar page is displayed, however, the personalized greeting and the **Start Quiz!** button are not visible and instead of quiz rules, the short text includes an invitation to test one's knowledge in the game.

![home](https://user-images.githubusercontent.com/87367190/186756826-8472061a-b59b-48b1-bf11-21e288db79dc.png)

The **Start Quiz!** button leads to the Quiz Page. Here the user can see a random shape of the country and choose one of three drawn answers. The position of the correct answer is also random. After clicking the **Submit** button, another country shape and three answer options appear.

![quiz](https://user-images.githubusercontent.com/87367190/186760070-c669b637-21a4-4fa3-b6cf-cb1bf072ca2e.png)

After submitting the fifth answer, the user is redirected to the Results Page. The score obtained is displayed, as well as the list of answers with color-coded country names depending on the correctness of the answer.

![results](https://user-images.githubusercontent.com/87367190/186761859-991b4f07-5594-496c-a071-3bb2c3856cb0.png)

The Admin Panel that allows managing the list of countries, along with the various functionalities, is as follows.

List of countires | Creating a new country | Editing the country | Deleting the country
:-------------------------:|:-------------------------:|:-------------------------:|:-------------------------:
![manager1](https://user-images.githubusercontent.com/87367190/186768279-e6df361a-d048-4f47-b414-8744e51214d8.png) | ![manager2](https://user-images.githubusercontent.com/87367190/186768307-1babbdf0-052e-495d-a313-c556d29a8981.png) | ![manager3](https://user-images.githubusercontent.com/87367190/186768342-67f364ea-6acc-4c4b-9887-f90913ceb519.png) | ![manager4](https://user-images.githubusercontent.com/87367190/186768370-f13b4544-b19a-4077-ac19-4ff759f061f1.png)

## Testing

You can register a new user, however there are two sample users created to test the application's functionality. 

- Regular User
  - Email Address/Username: **user1.com**
  - Password: **User1!**
- Administrator (with additional permissions)
  - Email Address/Username: **admin.com**
  - Password: **Admin1!**
  
## Resources

Images of country shapes: [https://github.com/djaiss/mapsicon](https://github.com/djaiss/mapsicon)
