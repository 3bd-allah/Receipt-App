import React from 'react'
import classes from './Item.module.css'
const Item = ({id, name, price, stock, onAdd}) => {
  return (
    <div>
        <button className={classes.item} onClick={()=>onAdd(id, name, price)}>
            <p className={classes.name}>{name}</p>
            <p className={classes.price}>{`${price} LE`}</p>
            <p>In Stock:<br/>{stock}</p>
        </button>
    </div>
    
  )
}

export default Item