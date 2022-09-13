@Output() marks a property in a child component as a doorway through which data can travel from the child to the parent.

The child component uses the @Output() property to raise an event to notify the parent of the change. To raise an event, an @Output() must have the type of EventEmitter, which is a class in @angular/core that you use to emit custom events.

The following example shows how to set up an @Output() in a child component that pushes data from an HTML <input> to an array in the parent component.

To use @Output(), you must configure the parent and child.