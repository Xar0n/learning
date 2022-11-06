import React, { useEffect, useState } from 'react'
import { CButton, CButtonGroup, CCard, CCardBody, CCol, CRow } from '@coreui/react'
import axios from 'axios'
import TableOffer from './TableOffer'

const Offer = () => {
  const [offersList, setOffersList] = useState([])
  const [loading, setLoading] = useState(true)
  useEffect(() => {
    axios.get('https://localhost:7162/api/Offer').then((response) => {
      // eslint-disable-next-line react-hooks/rules-of-hooks,react-hooks/exhaustive-deps
      setOffersList(response.data)
      setLoading(false)
    })
  }, [])

  const columns = React.useMemo(
    () => [
      {
        Header: '№',
        accessor: 'id',
        disableFilters: true,
      },
      {
        Header: 'Название',
        accessor: 'name',
        disableFilters: true,
      },
      {
        Header: 'Описание',
        accessor: 'description',
        disableFilters: true,
      },
    ],
    [],
  )

  if (loading) {
    return (
      <div className="pt-3 text-center">
        <div className="sk-spinner sk-spinner-pulse"></div>
      </div>
    )
  }

  return (
    <>
      <CCard className="mb-5">
        <CCardBody>
          <CRow className={'mb-5'}>
            <CCol sm={5}>
              <h4 id="object-header" className="card-title mb-0">
                Предложения
              </h4>
            </CCol>
          </CRow>
          <TableOffer columns={columns} data={offersList} />
        </CCardBody>
      </CCard>
    </>
  )
}
export default Offer
