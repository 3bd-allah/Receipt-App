import classes  from './ItemList.module.css'
import Item from './Item'
import { useEffect, useState } from 'react'
const ItemList = ({onUpdate}) => {
    
    
    const [items, setItems] = useState([])
    // items from fetching API

    useEffect(()=>{
        fetch("https://localhost:7179/api/items")
        .then(res => res.json())
        .then(data => {
            console.log(data)
            setItems(data)
        })
    },[])
    return (
    <>
        <ul className={classes.items}>
            {
               items.length !== 0? items.map(item => 
                <li key={item.id}>
                    <Item 
                        key={item.id} 
                        id={item.id}
                        name={item.name} 
                        price={item.price}
                        stock= {item.inStock}
                        onAdd={onUpdate}
                    />
                </li>)
               : <p>Loading....</p>
            }
        </ul>
    </>
  )
}

export default ItemList