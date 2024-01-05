import { useField } from 'formik'
import React from 'react'
import { FormField, Label } from 'semantic-ui-react'

export default function KodlamaIoTextInput({ ...props }) {
    // console.log(props)

    const [field, meta] = useField(props) // arka tarafta reflect api

    // console.log(field)
    // console.log(meta) 

    return (
        <div>
            <FormField error={meta.touched && !!meta.error}> {/* // !!string -> metin varsa true yoksa false */}
                <input {...field} {...props} />
                {meta.touched && !!meta.error ? (
                    <Label pointing color="red" content={meta.error}></Label>
                ) : null
                }
            </FormField>
        </div >
    )
}
