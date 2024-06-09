import { useState } from "react";
import classes from "./ReceiptModal.module.css";



const ReceiptModal = ({ receiptList, totalPrice, onCheckout, onClear, style }) => {
  const [remaining, setRemaining] = useState(0);
  const [paidAmount, setPaidAmount] = useState("");

  const calculateChange = () => {
    setRemaining(paidAmount - totalPrice);
  };

  const handleSubmit = (e)=>{
    e.preventDefault();
    console.log(receiptList)
    if(e.target[1].value !== ""){
      console.log("hello from if ")
      onCheckout(receiptList);
      setPaidAmount("");
      setRemaining(0)
      window.location.reload();
    }
  }
  return (
    <form onSubmit={handleSubmit}>
      <div className={classes.header} style={style}>
        <div></div>
        <div>
          <table style={{display:"block"}}>
            <tbody>
              <tr>
                <th>Title</th>
                <th style={{padding:15}}>Price</th>
                <th style={{padding:15}}>Quantity</th>
                <th>Total</th>
              </tr>
              {
                receiptList.length !== 0 ?receiptList.map(order => 
                  <tr>
                    <td>{order.name}</td>
                    <td>{order.price}</td>
                    <td>{order.Quantity}</td>
                    <td>{order.Quantity * order.price}</td>
                  </tr>
                )
                :
                <tr>
                  <td colSpan={4}>No items selected yet</td>
                </tr>
              }
            </tbody>
            <tfoot>
              <tr>
                <td colSpan={4}><button type="button" className="btn btn-danger" style={{width:200}} onClick={()=> {setRemaining(0); onClear();}} >Clear</button></td>
              </tr>
            </tfoot>
          </table>
        </div>
        <div>
          <div>
            <label style={{ display: "inline" }}>
              <h5>
                Cost: <h6>{totalPrice}&#160;&#160;LE</h6>
              </h5>
            </label>
          </div>
          <br />
          <div>
            <label>
              <h5>
                Paid Amount:
                <br />
              </h5>
              <input
                value={paidAmount}
                type="number"
                onChange={(e) => {
                  setPaidAmount(e.target.value);
                }}
                
              />
              <br />
            </label>
            <button type="button" className="btn btn-secondary" onClick={calculateChange}>Calc change</button>
          </div>
          <br />
          <div>
            <h5>
              Remaining: <h6>{remaining}&#160;&#160;LE</h6>
            </h5>
          </div>
          <div>
            <button  className="btn btn-primary" type="submit">Checkout</button>
          </div>
        </div>
      </div>
    </form>
  );
};

export default ReceiptModal;
