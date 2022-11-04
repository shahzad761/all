const express = require('express')



const app = express()
const port = 3000

app.get('/', (req, res) => {
  res.send('Hello World!')

})


  app.get('/coin', (req, res) => {
    //let Image_path= path.join(__dirname,'Kirito.jpg');
    //res.sendFile(Image_path)
    let a = req.query.name
    let a1= 25
    let a2= 10
    let a3= 5
    let a4= 1
    total=0
    number=0
    end= 0
    if (a == '1' || a == '5' || a == '10' || a == '25')
    {
      res.send('Number of coins is : 1')
    }
    else
    {
        
        do{  

            if (total   == a )
            {  end=1
                break;
            }
            
            total = total + a1
            number=number+1
         } while(total <= a)
            
       
         
        if (total != a)
        { 
        total = total -a1
        number=number-1
        }
        

// next step

do{  
    
    total = total + a2
    number=number+1
    
    
    } while(total <= a)
    
    if (total != a)
    { 
    total = total -a2
    number=number-1
    }

    
 // next step

 do{  

   

    total = total + a3
    number=number+1
    
    
     } while(total <= a)
    
     if (total != a)
     { 
    total = total -a3
    number=number-1
     }
       
     
     
 // next step

 do{  
  

    total = total + a4
    number=number+1
    
           } while(total <= a)
    
           if (total != a)
           { 
           total = total -a4
           number=number-1
           }

           res.send('you will receive '+number+' coins')
          // console.log(number)
           //res.send(''+total+'')

     
    }

         
         
  })



app.listen(port, () => {
  console.log(`Example app listening on port ${port}`)
})