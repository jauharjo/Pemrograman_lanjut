using TheNextCar.Model;

namespace TheNextCar.Controller
{
    class DoorController
    {
        private Door door;
        private OnDoorChanged callbackOnDoorChanged;

        public DoorController(OnDoorChanged callbackonDoorChanged)
        {
            this.callbackOnDoorChanged = callbackonDoorChanged;
            this.door = new Door();
        }

        public void close()
        {
            this.door.close();
            this.callbackOnDoorChanged.onDoorOpenStateChanged("CLOSED", "Door Closed");
        }

        public void open()
        {
            this.door.open();
            this.callbackOnDoorChanged.onDoorOpenStateChanged("OPENED", "Door Opened");
        }

        public void activateLock()
        {
            if (this.door.isClosed())
            {
                this.door.activateLock();
                this.callbackOnDoorChanged.onLockDoorStateChanged("LOCKED", "Door Locked");
            }
            else
            {
                unlock();
            }
            
        }

        public void unlock()
        {
            this.door.unlock();
            this.callbackOnDoorChanged.onLockDoorStateChanged("UNLOCKED", "Door Unlocked");
        }

        public bool isClose()
        {
            return this.door.isClosed();
        }

        public bool isLocked()
        {
            return this.door.isLocked();
        }
    }

    interface OnDoorChanged
    {
        void onLockDoorStateChanged(string value, string message);
        void onDoorOpenStateChanged(string value, string message);
    }
}
//https://github.com/nurjauharmuslih