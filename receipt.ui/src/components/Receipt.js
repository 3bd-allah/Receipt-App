import React, { useEffect, useState } from "react";
import ItemList from "./ItemList";
import ReceiptModal from "./ReceiptModal";

const Receipt = () => {
  const [orders, setOrders] = useState([]);
  const [total, setTotal] = useState(0);
  const [fixed, setFixed] = useState({});

  function updateOrderHandler(id, name, price) {
    const newOrder = { ItemId: id, name: name, price: price };
    setOrders((prevOrders) => {
      // check if the item is already in the receipt
      const existingOrder = prevOrders.find(
        (i) => i.ItemId === newOrder.ItemId
      );
      if (existingOrder) {
        // increase the quantity of existing item by one
        return prevOrders.map((i) =>
          i.ItemId === newOrder.ItemId ? { ...i, Quantity: i.Quantity + 1 } : i
        );
      } else {
        // Add new item in the receipt with quantity 1
        return [...prevOrders, { ...newOrder, Quantity: 1 }];
      }
    });
    setTotal((prevTotal) => prevTotal + price);
  }

  // useEffect(()=>{
  //   window.onscroll()
  //   if(window.scrollY > 300){
  //     setFixed({position:"fixed"})
  //   }
  // },[fixed])

  const checkoutHandler = (orderData) => {
    fetch("https://localhost:7179/api/orders", {
      method: "POST",
      body: JSON.stringify(orderData),
      headers: {
        "content-type": "application/json",
      },
    });
    setTotal(0);
    setOrders([]);
  };

  const clearHandler = () => {
    setOrders([]);
    setTotal(0);
  };
  return (
    <main style={{ width: "70%", display: "block", margin: "auto" }}>
      <ReceiptModal
        style={fixed}
        onCheckout={checkoutHandler}
        receiptList={orders}
        totalPrice={total}
        onClear={clearHandler}
      />
      <ItemList onUpdate={updateOrderHandler} />
    </main>
  );
};

export default Receipt;
