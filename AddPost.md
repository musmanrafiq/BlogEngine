## Add New Post Use Cases

#### 1) We need to create request and response objects to insert and get posts

request data 
{
    Title: string
    Content: string
    CreatedOn: DateTime
}

response data 
{
    Title: string
    Content: string
    CreatedOn: DateTime
}

#### We need validation of our request model

1) Request model (post) not null
2) Post title not empty
3) Post body not empty
4) Created date is set as current date

#### Before adding post in database, check title is not already exists



